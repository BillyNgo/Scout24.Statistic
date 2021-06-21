using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using Microsoft.Extensions.Configuration;
using Scout24.Statistic.App.Models;
using Scout24.Statistic.Internal;
using Scout24.Statistic.Reactive;

namespace Scout24.Statistic.App
{
    static class GitStatistic
    {
        public static GitOption GitOption;
        public static InMemoryCredentialStore Credentials;
        public static ObservableGitHubClient Client;
        public static DateRange DateRange;
        public static List<Repository> RepositoryList;
        public static void PopulateOptionData()
        {
            var dateFrom = DateTime.ParseExact($"{GitOption.DateFrom}", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            var dateTo = DateTime.ParseExact($"{GitOption.DateTo}", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            DateTimeOffset from = new DateTimeOffset(dateFrom);
            DateTimeOffset to = new DateTimeOffset(dateTo);
            DateRange = new DateRange(from, to);
            Credentials = new InMemoryCredentialStore(new Credentials(GitOption.AccessToken));
            Client = new ObservableGitHubClient(new ProductHeaderValue(GitOption.Owner), Credentials, new Uri(GitOption.BaseUrl));
        }



        public static void DrawStatisticTable()
        {
            for (int j = 0; j < GitOption.Teams.Count; j++)
            {
                var name = GitOption.Teams[j].Members.Select(c => c.DisplayName).ToArray();
                name = new[] { GitOption.Teams[j].Name }.Concat(name).ToArray();
                var prCount = GitOption.Teams[j].Members.Select(c => c.PrCount.ToString()).ToArray();
                prCount = new[] { "PRs Count" }.Concat(prCount).ToArray();
                var reviewCount = GitOption.Teams[j].Members.Select(c => c.ReviewCount.ToString()).ToArray();
                reviewCount = new[] { "Review Count" }.Concat(reviewCount).ToArray();
                Console.WriteLine();
                var table = new ConsoleTable(name)
                {
                    Options = { EnableCount = false }
                };

                table.AddRow(prCount).AddRow(reviewCount);
                table.Write();
            }
        }

        public static async Task PopulateRepositoriesData()
        {
            RepositoryList = new List<Repository>();
            Client.Repository.GetAllForOrg(GitOption.Owner).Subscribe(data =>
            {
                RepositoryList.Add(data);
            });
        }

        public static async Task PopulateStatisticData()
        {
            for (int j = 0; j < GitOption.Teams.Count; j++)
            {
                for (int i = 0; i < GitOption.Teams[j].Members.Count; i++)
                {
                    GitOption.Teams[j].Members[i].PrCount = await CountPullRequest(GitOption.Teams[j].Members[i].UserName, DateRange);
                    GitOption.Teams[j].Members[i].ReviewCount = await CountReview(GitOption.Teams[j].Members[i].UserName, DateRange);
                }
            }
        }

        public static async Task<int> CountPullRequest(string contributor, DateRange dateRange)
        {
            var pullRequestList = await Client.Search.SearchIssues(new SearchIssuesRequest
            {
                Type = IssueTypeQualifier.PullRequest,
                Merged = dateRange,
                Author = contributor
            });
            return pullRequestList.TotalCount;
        }

        public static async Task<int> CountReview(string contributor, DateRange dateRange)
        {
            var reviewList = await Client.Search.SearchIssues(new SearchIssuesRequest
            {
                Type = IssueTypeQualifier.PullRequest,
                Closed = dateRange,
                ReviewedBy = contributor
            });
            return reviewList.TotalCount;
        }

        private static T InitOptions<T>(string section)
            where T : new()
        {
            return InitConfig().GetSection(section).Get<T>();
        }

        private static IConfigurationRoot InitConfig()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            return configurationBuilder.Build();
        }
    }
}
