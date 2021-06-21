using System.Collections.Generic;
using System.Diagnostics;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchRepositoryResult : SearchResult<Repository>
    {
        public SearchRepositoryResult() { }

        public SearchRepositoryResult(int totalCount, bool incompleteResults, IReadOnlyList<Repository> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}
