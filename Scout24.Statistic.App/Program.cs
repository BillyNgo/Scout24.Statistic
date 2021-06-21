using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleTables;
using Microsoft.Extensions.Configuration;
using Scout24.Statistic.App.Models;
using Atlassian.Jira;
namespace Scout24.Statistic.App
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DrawCopyrightTable();
            
            GitStatistic.GitOption = InitOptions<GitOption>("GitOption");
            if (GitStatistic.GitOption.Enabled)
            {
                Console.WriteLine("===============  GITHUB STATISTIC ===============");
                Console.WriteLine("\nWorking...\n");
                GitStatistic.PopulateOptionData();
                await GitStatistic.PopulateStatisticData();
                GitStatistic.DrawStatisticTable();
            }

            JiraStatistic.JiraOption = InitOptions<JiraOption>("JiraOption");
            if (JiraStatistic.JiraOption.Enabled)
            {
                Console.WriteLine("================  JIRA STATISTIC ================");
                Console.WriteLine("\nWorking...\n");
                JiraStatistic.PopulateOptionData();
                await JiraStatistic.PopulateStatisticData();
                JiraStatistic.DrawStatisticTable();
            }

            Console.ReadLine();
        }

        public static void  DrawCopyrightTable()
        {
            Console.Clear();
            var table = new ConsoleTable(" ", "Copyright & License")
            {
                Options = { EnableCount = false }
            };

            table
                .AddRow("Version", "1.0")
                .AddRow("Author", "Billy Ngo")
                .AddRow("License", "Scout24 Schweiz AG")
                .AddRow("Description", "Count number of tasks, pull request and review for a vertical team members");

            table.Write();
            Console.WriteLine("");
            Console.WriteLine("Please note this statistic is just for reference only! There are some other effort beyond of this such as: researching topic, new other codebase/repositories (we are moving to micro services) which could not count in this statistic, all member of team involved to find the root cause of urgent incident/bugs (only 1 task on jira), supporting others, meeting....");
            Console.WriteLine("");
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

