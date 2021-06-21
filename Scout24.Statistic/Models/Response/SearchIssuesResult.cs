using System.Collections.Generic;
using System.Diagnostics;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchIssuesResult : SearchResult<Issue>
    {
        public SearchIssuesResult() { }

        public SearchIssuesResult(int totalCount, bool incompleteResults, IReadOnlyList<Issue> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}