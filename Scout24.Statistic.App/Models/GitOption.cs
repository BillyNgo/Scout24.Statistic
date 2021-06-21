using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout24.Statistic.App.Models
{
    public class GitOption
    {
        public bool Enabled { get; set; }
        public string BaseUrl { get; set; }
        public string AccessToken { get; set; }
        public string Owner { get; set; }
        public List<GitTeam> Teams { get; set; }
        public string DateFrom { get; set; }
        public string DateTo { get; set; }
    }
}
