namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {
        public void AddBearerAuthentication(string token)
        {
            string key = "Authorization";
            this.setHeader(key, $"Bearer {token}");
        }
    }
}
