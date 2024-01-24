using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
	public partial class HttpClientPlus
	{

		public Task<HttpResponseMessage?> PostAsync(Uri requestUri, HttpContent content)
		{
			var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
			request.Content = content;
			return this.SendAsync(request);
		}

		public Task<HttpResponseMessage?> PostAsync(string requestUri, HttpContent content)
		{
			var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
			request.Content = content;
			return this.SendAsync(request);
		}

		public Task<HttpResponseMessage?> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{

			var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
			request.Content = content;
			return this.SendAsync(request, cancellationToken);
		}

		public Task<HttpResponseMessage?> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{

			var request = new HttpRequestMessage(HttpMethod.Post, requestUri);
			request.Content = content;
			return this.SendAsync(request, cancellationToken);
		}

	}
}
