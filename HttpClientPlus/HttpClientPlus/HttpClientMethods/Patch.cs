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
			var request = new HttpRequestMessage(HttpMethod.Patch, requestUri);
			request.Content = content;

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request);
			}
			, content);
		}

		public Task<HttpResponseMessage?> PatchAsync(string requestUri, HttpContent content)
		{
			var request = new HttpRequestMessage(HttpMethod.Patch, requestUri);
			request.Content = content;

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request);
			}
			, content);
		}

		public Task<HttpResponseMessage?> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var request = new HttpRequestMessage(HttpMethod.Patch, requestUri);
			request.Content = content;

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request,cancellationToken);
			}
			, content);
		}

		public Task<HttpResponseMessage?> PatchAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			var request = new HttpRequestMessage(HttpMethod.Patch, requestUri);
			request.Content = content;

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request, cancellationToken);
			}
			, content);
		}

	}
}
