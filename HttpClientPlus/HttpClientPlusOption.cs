using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public class HttpClientPlusOption
    {
        public virtual Task BeforeExecuteAsync() => Task.CompletedTask;
        public virtual Task AfterExecuteAsync<TResponse>(TResponse response) => Task.CompletedTask;
        public virtual Task WhenHasErrorAsync() => Task.CompletedTask;
        public virtual Task FinalAsync() => Task.CompletedTask;

        public Dictionary<string, string>? DefaultHeaders { get; private set; }

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

