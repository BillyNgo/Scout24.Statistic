using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class ForkEventPayload : ActivityPayload
    {
        public Repository Forkee { get; protected set; }
    }
}
