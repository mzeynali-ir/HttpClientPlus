using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IMustafa.Web
{
	public abstract partial class HttpClientPlusOption : IDisposable
	{
		public List<RequestHeader>? DefaultHeaders { get; private set; }
		public AuthorizationType? DefaultAuthorization { get; private set; }
		protected HttpContent? HttpContent { get; private set; }
		protected HttpRequestMessage? HttpRequestMessage { get; private set; }
		public void SetHttpContent(HttpContent? httpContent) => this.HttpContent = httpContent;
		public void SetHttpRequestMessage(HttpRequestMessage? HttpRequestMessage) => this.HttpRequestMessage = HttpRequestMessage;

		public async Task<string> GetCurlAsync(HttpRequestMessage request)
		{
			var methodType = request.Method;
			var r = "";
			if (methodType == HttpMethod.Patch) r = "--request PATCH";
			if (methodType == HttpMethod.Post) r = "";
			if (methodType == HttpMethod.Get) r = "--request GET";
			if (methodType == HttpMethod.Put) r = "--request PUT";
			if (methodType == HttpMethod.Delete) r = "--request DELETE";

			var url = $"curl --location {r} '{request.RequestUri}' \\";

			string headers = "";
			foreach (var header in request.Headers)
			{
				headers += $"--header '{header.Key}:{header.Value.First()}' \\";
			}

			//data
			var content = default(string);
			if (request != null)
				if (request.Content != null)
					content = await request?.Content?.ReadAsStringAsync()!;

			string data = $"--data '{content}'";

			return url + headers + data;
		}

		public void Dispose()
		{

		}
	}
}

