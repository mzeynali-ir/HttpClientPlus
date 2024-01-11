﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<HttpResponseMessage?> DeleteAsync(Uri requestUri)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.DeleteAsync(requestUri);
            });
        }

        public Task<HttpResponseMessage?> DeleteAsync(string requestUri)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.DeleteAsync(requestUri);
            });
        }

        public Task<HttpResponseMessage?> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.DeleteAsync(requestUri, cancellationToken);
            });
        }

        public Task<HttpResponseMessage?> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.DeleteAsync(requestUri, cancellationToken);
            });
        }

    }
}