using System.Collections.Generic;
using System.Diagnostics;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class DeleteEventPayload : ActivityPayload
    {
        public string Ref { get; protected set; }

        public StringEnum<RefType> RefType { get; protected set; }
    }
}
