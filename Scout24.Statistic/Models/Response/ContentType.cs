using System.Diagnostics.CodeAnalysis;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    /// <summary>
    /// The possible repository content types.
    /// </summary>
    public enum ContentType
    {
        [Parameter(Value = "file")]
        File,

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Dir", Justification = "Matches the value returned by the API")]
        [Parameter(Value = "dir")]
        Dir,

        [Parameter(Value = "symlink")]
        Symlink,

        [Parameter(Value = "submodule")]
        Submodule
    }
}