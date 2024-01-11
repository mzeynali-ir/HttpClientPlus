using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<HttpResponseMessage?> PatchAsync(Uri requestUri, HttpContent content)
        {
            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PatchAsync(requestUri, content);
            });
        }

        public Task<HttpResponseMessage?> PatchAsync(string requestUri, HttpContent content)
        {
            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PatchAsync(requestUri, content);
            });
        }

        public Task<HttpResponseMessage?> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PatchAsync(requestUri, content, cancellationToken);
            });
        }

        public Task<HttpResponseMessage?> PatchAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PatchAsync(requestUri, content, cancellationToken);
            });
        }

    }
}
