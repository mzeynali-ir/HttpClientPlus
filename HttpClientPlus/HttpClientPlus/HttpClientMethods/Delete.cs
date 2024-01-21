using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<HttpResponseMessage?> DeleteAsync(Uri requestUri)
        {
			var request = new HttpRequestMessage(HttpMethod.Delete, requestUri);

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request);
			});
		}

        public Task<HttpResponseMessage?> DeleteAsync(string requestUri)
        {
			var request = new HttpRequestMessage(HttpMethod.Delete, requestUri);

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request);
			});
		}

        public Task<HttpResponseMessage?> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
			var request = new HttpRequestMessage(HttpMethod.Delete, requestUri);

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request,cancellationToken);
			});
		}

        public Task<HttpResponseMessage?> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
			var request = new HttpRequestMessage(HttpMethod.Delete, requestUri);

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request, cancellationToken);
			});
		}

    }
}
