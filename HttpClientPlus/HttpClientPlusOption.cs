﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace IMustafa
{
    public class HttpClientPlusOption
    {
        public virtual Task BeforeExecuteAsync() => Task.CompletedTask;
        public virtual Task AfterExecuteAsync(HttpResponseMessage response) => Task.CompletedTask;
        public virtual Task WhenHasErrorAsync() => Task.CompletedTask;
        public virtual Task FinalAsync() => Task.CompletedTask;

        public Dictionary<string, string>? DefaultHeaders { get; private set; }

        public void SetDefaultHeaders(Dictionary<string, string> headers)
        {
            DefaultHeaders = headers;
        }
    }
}

