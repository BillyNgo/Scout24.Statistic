using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout24.Statistic.App.Models
{
    public class JiraOption
    {
        public bool Enabled { get; set; }
        public string BaseUrl { get; set; }
        public string UserName { get; set; }
        public string AccessToken { get; set; }
        public List<JiraTeam> Teams { get; set; }
        public string Jql { get; set; }

    }
}
