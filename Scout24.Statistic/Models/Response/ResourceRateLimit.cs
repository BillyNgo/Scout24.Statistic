using System.Diagnostics;
using System.Globalization;

namespace Scout24.Statistic
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class ResourceRateLimit
    {
        public ResourceRateLimit() { }

        public ResourceRateLimit(RateLimit core, RateLimit search)
        {
            Ensure.ArgumentNotNull(core, nameof(core));
            Ensure.ArgumentNotNull(search, nameof(search));

            Core = core;
            Search = search;
        }

        /// <summary>
        /// Rate limits for core API (rate limit for everything except Search API)
        /// </summary>
        public RateLimit Core { get; private set; }

        /// <summary>
        /// Rate Limits for Search API
        /// </summary>
        public RateLimit Search { get; private set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Core: {0}; Search: {1} ", Core.DebuggerDisplay, Search.DebuggerDisplay);
            }
        }
    }
}
