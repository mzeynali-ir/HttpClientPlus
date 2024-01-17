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

			return this.coreAsync(() =>
			{
				return _httpClient.PutAsync(requestUri, content);
			}
			, content);

		}

		public Task<HttpResponseMessage?> PutAsync(string requestUri, HttpContent content)
		{
			return this.coreAsync(() =>
			{
				return _httpClient.PutAsync(requestUri, content);
			}
			, content);
		}

		public Task<HttpResponseMessage?> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{

			return this.coreAsync(() =>
			{
				return _httpClient.PutAsync(requestUri, content, cancellationToken);
			}
			, content);

		}

		public Task<HttpResponseMessage?> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.coreAsync(() =>
			{
				return _httpClient.PutAsync(requestUri, content, cancellationToken);
			}
			, content);
		}

	}
}
