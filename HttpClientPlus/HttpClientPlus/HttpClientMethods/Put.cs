using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
	public partial class HttpClientPlus
	{

		public Task<HttpResponseMessage?> PutAsync(Uri requestUri, HttpContent content)
		{

			var request = new HttpRequestMessage(HttpMethod.Put, requestUri);
			request.Content = content;
			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request);
			});

		}

		public Task<HttpResponseMessage?> PutAsync(string requestUri, HttpContent content)
		{
			var request = new HttpRequestMessage(HttpMethod.Put, requestUri);
			request.Content = content;
			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request);
			});
		}

		public Task<HttpResponseMessage?> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{

			var request = new HttpRequestMessage(HttpMethod.Put, requestUri);
			request.Content = content;
			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request, cancellationToken);
			});

		}

		public Task<HttpResponseMessage?> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var request = new HttpRequestMessage(HttpMethod.Put, requestUri);
			request.Content = content;
			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request, cancellationToken);
			});
		}

	}
}
