using System;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {
        public void AddBasicAuthentication(string base64EncodedAuthenticationString)
        {
            string key = "Authorization";
            this.setHeaders(key, $"Basic {base64EncodedAuthenticationString}");
        }

        public void AddBasicAuthentication(string clientId, string clientSecret)
        {
            var authenticationString = $"{clientId}:{clientSecret}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(authenticationString));
            string key = "Authorization";
            this.setHeaders(key, $"Basic {base64EncodedAuthenticationString}");
        }
    }
}
