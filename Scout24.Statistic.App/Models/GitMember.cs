using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout24.Statistic.App.Models
{
    public class GitMember
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public int PrCount { get; set; }
        public int ReviewCount { get; set; }
    }
}
