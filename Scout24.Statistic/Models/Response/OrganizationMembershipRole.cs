using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    public enum OrganizationMembershipRole
    {
        [Parameter(Value = "direct_member")]
        DirectMember,
        [Parameter(Value = "admin")]
        Admin,
        [Parameter(Value = "billing_manager")]
        BillingManager,
        [Parameter(Value = "hiring_manager")]
        HiringManager,
        [Parameter(Value = "reinstate")]
        Reinstate
    }
}