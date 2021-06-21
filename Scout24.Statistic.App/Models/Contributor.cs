using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout24.Statistic.App.Models
{
    public class Contributor
    {
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public int PrCount { get; set; }
        public int ReviewCount { get; set; }
        public int TaskCount { get; set; }
        public int PointCount { get; set; }
    }
}
