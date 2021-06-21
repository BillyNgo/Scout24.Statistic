using System.Collections.Generic;
using System.Diagnostics;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchLabelsResult : SearchResult<Label>
    {
        public SearchLabelsResult() { }

        public SearchLabelsResult(int totalCount, bool incompleteResults, IReadOnlyList<Label> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}