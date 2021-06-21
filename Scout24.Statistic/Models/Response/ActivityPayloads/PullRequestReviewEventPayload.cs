using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PullRequestReviewEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public PullRequest PullRequest { get; protected set; }
        public PullRequestReview Review { get; protected set; }
    }
}
