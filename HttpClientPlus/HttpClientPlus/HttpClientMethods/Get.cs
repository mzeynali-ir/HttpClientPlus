using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<HttpResponseMessage?> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri, cancellationToken);
            });
        }

        public Task<HttpResponseMessage?> GetAsync(Uri requestUri)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri);
            });
        }

        public Task<HttpResponseMessage?> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri, completionOption);
            });
        }

        public Task<HttpResponseMessage?> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri, completionOption);
            });
        }

        public Task<HttpResponseMessage?> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri, cancellationToken);
            });
        }

        public Task<HttpResponseMessage?> GetAsync(string requestUri)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri);
            });
        }

        public Task<HttpResponseMessage?> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
            });
        }

        public Task<HttpResponseMessage?> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri, completionOption, cancellationToken);
            });
        }

    }
}
