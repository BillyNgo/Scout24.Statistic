using System.Threading;
using System.Threading.Tasks;
using Scout24.Statistic.Internal;

namespace Scout24.Statistic
{
    public static class HttpClientExtensions
    {
        public static Task<IResponse> Send(this IHttpClient httpClient, IRequest request)
        {
            Ensure.ArgumentNotNull(httpClient, nameof(httpClient));
            Ensure.ArgumentNotNull(request, nameof(request));

            return httpClient.Send(request, CancellationToken.None);
        }
    }
}