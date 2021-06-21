using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class CommitCommentPayload : ActivityPayload
    {
        public CommitComment Comment { get; protected set; }
    }
}
