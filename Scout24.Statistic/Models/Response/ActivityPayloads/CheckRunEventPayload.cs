using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class CheckRunEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public CheckRun CheckRun { get; protected set; }
        public CheckRunRequestedAction RequestedAction { get; protected set; }
    }
}
