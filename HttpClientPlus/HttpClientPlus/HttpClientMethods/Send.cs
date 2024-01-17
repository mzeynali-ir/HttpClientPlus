using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
	public partial class HttpClientPlus
	{

		public Task<HttpResponseMessage?> SendAsync(HttpRequestMessage request)
		{
			_config.SetHttpRequestMessage(request);

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request);
			});
		}

		public Task<HttpResponseMessage?> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			_config.SetHttpRequestMessage(request);

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request, completionOption);
			});
		}

		public Task<HttpResponseMessage?> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			_config.SetHttpRequestMessage(request);

			return this.coreAsync(() =>
			{
				return _httpClient.SendAsync(request, completionOption, cancellationToken);
			});
		}

	}
}
