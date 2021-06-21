using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PullRequestEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public int Number { get; protected set; }

        public PullRequest PullRequest { get; protected set; }
    }
}
