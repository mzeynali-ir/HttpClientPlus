using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<HttpResponseMessage?> SendAsync(HttpRequestMessage request)
        {
            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.SendAsync(request);
            });
        }

        public Task<HttpResponseMessage?> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.SendAsync(request, completionOption);
            });
        }

        public Task<HttpResponseMessage?> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.SendAsync(request, completionOption, cancellationToken);
            });
        }

    }
}
