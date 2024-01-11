namespace IMustafa
{
    public partial class HttpClientPlus
    {
        public void AddBearerAuthentication(string token)
        {
            string key = "Authorization";
            this.setHeaders(key, $"Bearer {token}");
        }
    }
}
