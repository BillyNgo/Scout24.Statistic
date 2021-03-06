using System.Diagnostics;
using System.Globalization;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class TeamMembershipDetails
    {
        public TeamMembershipDetails() { }

        public TeamMembershipDetails(TeamRole role, MembershipState state)
        {
            Role = role;
            State = state;
        }

        public StringEnum<TeamRole> Role { get; protected set; }

        public StringEnum<MembershipState> State { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Role: {0} State: {1}", Role, State);
            }
        }
    }

    /// <summary>
    /// Roles within a Team
    /// </summary>
    public enum TeamRole
    {
        /// <summary>
        /// Regular Team Member
        /// </summary>
        [Parameter(Value = "member")]
        Member,

        /// <summary>
        ///  Team Maintainer
        /// </summary>
        [Parameter(Value = "maintainer")]
        Maintainer
    }
}
