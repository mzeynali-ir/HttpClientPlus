using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public abstract partial class HttpClientPlusOption
    {
        public void SetDefaultHeaders(List<RequestHeader> headers)
        {
            DefaultHeaders = headers;
        }

        public void SetDefaultHeaders(Func<List<RequestHeader>> getDefaultHeadersFunc)
        {
            DefaultHeaders = getDefaultHeadersFunc();
        }

        public async void SetDefaultHeadersAsync(Func<Task<List<RequestHeader>>> getDefaultHeadersFunc)
        {
            DefaultHeaders = await getDefaultHeadersFunc();
        }

    }
}

