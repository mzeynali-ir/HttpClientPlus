using System;
using System.Collections.Generic;
using System.Net.Http;

namespace IMustafa.Web
{
	public abstract partial class HttpClientPlusOption : IDisposable
	{
		public List<RequestHeader>? DefaultHeaders { get; private set; }
		public AuthorizationType? DefaultAuthorization { get; private set; }
		protected HttpContent? HttpContent { get; private set; }
		public void SetHttpContent(HttpContent httpContent) => this.HttpContent = httpContent;

		public void Dispose()
		{

		}
	}
}

