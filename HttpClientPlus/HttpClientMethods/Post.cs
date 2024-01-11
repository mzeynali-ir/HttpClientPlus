using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa
{
    public partial class HttpClientPlus
    {

        public Task<HttpResponseMessage?> PostAsync(Uri requestUri, HttpContent content)
        {

            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PostAsync(requestUri, content);
            });

        }

        public Task<HttpResponseMessage?> PostAsync(string requestUri, HttpContent content)
        {

            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PostAsync(requestUri, content);
            });

        }

        public Task<HttpResponseMessage?> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {

            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PostAsync(requestUri, content, cancellationToken);
            });

        }

        public Task<HttpResponseMessage?> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {

            return this.coreAsync<HttpResponseMessage>(() =>
            {
                return _httpClient.PostAsync(requestUri, content, cancellationToken);
            });

        }

    }
}
