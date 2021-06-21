using System.Net.Http;

namespace Scout24.Statistic.Internal
{
    internal static class HttpVerb
    {
        static readonly HttpMethod patch = new HttpMethod("PATCH");

        internal static HttpMethod Patch
        {
            get { return patch; }
        }
    }
}
