using System.Collections.Generic;
using System.Diagnostics;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchUsersResult : SearchResult<User>
    {
        public SearchUsersResult() { }

        public SearchUsersResult(int totalCount, bool incompleteResults, IReadOnlyList<User> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}