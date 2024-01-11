using System;
using System.Collections.Generic;

namespace IMustafa.Web
{
    public abstract partial class HttpClientPlusOption : IDisposable
    {
        public List<RequestHeader>? DefaultHeaders { get; private set; }
        public AuthorizationType? DefaultAuthorization { get; private set; }

        public void Dispose()
        {

        }
    }
}

