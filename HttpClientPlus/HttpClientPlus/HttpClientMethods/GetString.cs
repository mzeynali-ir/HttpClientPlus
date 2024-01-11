using System;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<string?> GetStringAsync(string requestUri)
        {
            return this.coreAsync<string>(() =>
            {
                return _httpClient.GetStringAsync(requestUri);
            });
        }

        public Task<string?> GetStringAsync(Uri requestUri)
        {
            return this.coreAsync<string>(() =>
            {
                return _httpClient.GetStringAsync(requestUri);
            });
        }

    }
}
