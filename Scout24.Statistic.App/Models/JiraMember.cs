using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout24.Statistic.App.Models
{
    public class JiraMember
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string AccountId { get; set; }
        public int TaskCount { get; set; }
    }
}
