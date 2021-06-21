using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atlassian.Jira;
using ConsoleTables;
using Microsoft.Extensions.Configuration;
using Scout24.Statistic.App.Models;

namespace Scout24.Statistic.App
{
    static class JiraStatistic
    {
        public static JiraOption JiraOption;
        public static Jira Client;
        public static void PopulateOptionData()
        {
            Client = Jira.CreateRestClient(JiraOption.BaseUrl, JiraOption.UserName, JiraOption.AccessToken);
            Client.Issues.MaxIssuesPerRequest = 10000;
        }

        public static void DrawStatisticTable()
        {
            for (int j = 0; j < JiraOption.Teams.Count; j++)
            {
                var name = JiraOption.Teams[j].Members.Select(c => c.DisplayName).ToArray();
                name = new[] { JiraOption.Teams[j].Name }.Concat(name).ToArray();
                var taskCount = JiraOption.Teams[j].Members.Select(c => c.TaskCount.ToString()).ToArray();
                taskCount = new[] { "Task Count" }.Concat(taskCount).ToArray();
                Console.WriteLine();
                var table = new ConsoleTable(name)
                {
                    Options = { EnableCount = false }
                };

                table.AddRow(taskCount);
                table.Write();
            }
        }

        public static async Task PopulateStatisticData()
        {
            for (int j = 0; j < JiraOption.Teams.Count; j++)
            {
                for (int i = 0; i < JiraOption.Teams[j].Members.Count; i++)
                {
                    JiraOption.Teams[j].Members[i].TaskCount = await CountTask(JiraOption.Teams[j].Members[i].AccountId);
                }
            }
        }

        public static async Task<int> CountTask(string accountId)
        {

            var issuesSearchOption = new IssueSearchOptions(JiraOption.Jql.Replace("{accountId}", accountId));
            var tasks = await Client.Issues.GetIssuesFromJqlAsync(issuesSearchOption);
            return tasks.TotalItems;
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
