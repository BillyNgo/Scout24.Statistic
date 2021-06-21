using System.Collections.Generic;
using System.Diagnostics;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchCodeResult : SearchResult<SearchCode>
    {
        public SearchCodeResult() { }

        public SearchCodeResult(int totalCount, bool incompleteResults, IReadOnlyList<SearchCode> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}