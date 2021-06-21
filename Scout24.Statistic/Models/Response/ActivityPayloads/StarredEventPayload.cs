using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class StarredEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
    }
}
