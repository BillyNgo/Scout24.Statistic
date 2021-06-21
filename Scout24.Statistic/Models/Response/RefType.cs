using System;
using System.Diagnostics;
using System.Globalization;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    /// <summary>
    /// Represents the type of object created or deleted
    /// </summary>
    public enum RefType
    {
        /// <summary>
        /// The object is of type repository
        /// </summary>
        [Parameter(Value = "repository")]
        Repository,

        /// <summary>
        /// The object is of type branch
        /// </summary>
        [Parameter(Value = "branch")]
        Branch,

        /// <summary>
        /// The object is of type tag
        /// </summary>
        [Parameter(Value = "tag")]
        Tag
    }
}
