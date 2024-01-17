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

			return this.coreAsync(() =>
			{
				return _httpClient.PostAsync(requestUri, content);
			}
			, content);

		}

		public Task<HttpResponseMessage?> PostAsync(string requestUri, HttpContent content)
		{

			return this.coreAsync(() =>
			{
				return _httpClient.PostAsync(requestUri, content);
			}
			, content);

		}

		public Task<HttpResponseMessage?> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{

			return this.coreAsync(() =>
			{
				return _httpClient.PostAsync(requestUri, content, cancellationToken);
			}
			, content);

		}

		public Task<HttpResponseMessage?> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{

			return this.coreAsync(() =>
			{
				return _httpClient.PostAsync(requestUri, content, cancellationToken);
			}
			, content);

		}

	}
}
