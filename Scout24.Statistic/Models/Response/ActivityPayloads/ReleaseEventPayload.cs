using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class ReleaseEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }

        public Release Release { get; protected set; }
    }
}
