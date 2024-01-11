using System.Collections.Generic;

namespace IMustafa.Web
{
    public abstract partial class HttpClientPlusOption
    {
        public List<RequestHeader>? DefaultHeaders { get; private set; }
        public AuthorizationType? DefaultAuthorization { get; private set; }
    }
}

