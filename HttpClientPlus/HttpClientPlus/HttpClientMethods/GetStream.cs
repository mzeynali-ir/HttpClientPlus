﻿using System;
using System.IO;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<Stream?> GetStreamAsync(string requestUri)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetStreamAsync(requestUri);
            });
        }

        public Task<Stream?> GetStreamAsync(Uri requestUri)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.GetStreamAsync(requestUri);
            });
        }

    }
}
