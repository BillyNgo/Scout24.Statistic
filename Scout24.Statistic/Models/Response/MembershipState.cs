using System;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    /// <summary>
    /// States of a Team/Organization Membership
    /// </summary>
    public enum MembershipState
    {
        /// <summary>
        /// The membership is pending
        /// </summary>
        [Parameter(Value = "pending")]
        Pending,

        /// <summary>
        /// The membership is active
        /// </summary>
        [Parameter(Value = "active")]
        Active
    }
}
