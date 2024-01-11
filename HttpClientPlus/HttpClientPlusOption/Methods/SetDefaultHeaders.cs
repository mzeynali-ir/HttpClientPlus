using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public abstract partial class HttpClientPlusOption
    {
        public void SetDefaultHeaders(Dictionary<string, string> headers)
        {
            DefaultHeaders = headers;
        }

        public void SetDefaultHeaders(Func<Dictionary<string, string>> getDefaultHeadersFunc)
        {
            DefaultHeaders = getDefaultHeadersFunc();
        }

        public async void SetDefaultHeadersAsync(Func<Task<Dictionary<string, string>>> getDefaultHeadersFunc)
        {
            DefaultHeaders = await getDefaultHeadersFunc();
        }
    }
}

