namespace IMustafa.Web
{
    public abstract partial class HttpClientPlusOption
    {
        public void SetDefaultAuthorization(AuthorizationType authorization)
        {
            DefaultAuthorization = authorization;
        }
    }
}

