using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PullRequestCommentPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public PullRequest PullRequest { get; protected set; }
        public PullRequestReviewComment Comment { get; protected set; }
    }
}
