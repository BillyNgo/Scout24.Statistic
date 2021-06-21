using System.Diagnostics;
using System.Globalization;
using Scout24.Statistic.Internal;
using System.Collections.Generic;

namespace Scout24.Statistic
{
    /// <summary>
    /// Used to dismiss a pull request review
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class PullRequestReviewDismiss : RequestParameters
    {
        public PullRequestReviewDismiss()
        {
        }

        /// <summary>
        /// The message explaining why this review is being dismissed
        /// </summary>
        public string Message { get; set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Message: {0} ", Message);
            }
        }
    }
}
