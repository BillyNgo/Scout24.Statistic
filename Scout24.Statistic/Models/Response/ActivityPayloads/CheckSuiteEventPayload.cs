using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class CheckSuiteEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public CheckSuite CheckSuite { get; protected set; }
    }
}
