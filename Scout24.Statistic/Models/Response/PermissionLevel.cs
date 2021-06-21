using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    public enum PermissionLevel
    {
        [Parameter(Value = "admin")]
        Admin,
        [Parameter(Value = "write")]
        Write,
        [Parameter(Value = "read")]
        Read,
        [Parameter(Value = "none")]
        None
    }
}
