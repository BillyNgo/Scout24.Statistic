using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout24.Statistic.App.Models
{
    public class GitTeam
    {
        public string Name { get; set; }
        public List<GitMember> Members { get; set; }
    }
}
