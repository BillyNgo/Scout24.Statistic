using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    public enum AccountType
    {
        /// <summary>
        ///  User account
        /// </summary>
        [Parameter(Value = "User")]
        User,

        /// <summary>
        /// Organization account
        /// </summary>
        [Parameter(Value = "Organization")]
        Organization,

        /// <summary>
        /// Bot account
        /// </summary>
        [Parameter(Value = "Bot")]
        Bot
    }
}
