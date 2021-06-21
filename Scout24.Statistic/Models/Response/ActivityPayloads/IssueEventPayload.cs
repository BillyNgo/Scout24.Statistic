using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class IssueEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public Issue Issue { get; protected set; }
    }
}
