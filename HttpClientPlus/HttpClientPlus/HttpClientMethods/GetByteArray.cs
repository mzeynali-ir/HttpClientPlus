using System;
using System.Threading.Tasks;

namespace IMustafa.Web
{
    public partial class HttpClientPlus
    {

        public Task<byte[]?> GetByteArrayAsync(string requestUri)
        {
            return this.coreAsync<byte[]>(() =>
            {
                return _httpClient.GetByteArrayAsync(requestUri);
            });
        }

        public Task<byte[]?> GetByteArrayAsync(Uri requestUri)
        {
            return this.coreAsync<byte[]>(() =>
            {
                return _httpClient.GetByteArrayAsync(requestUri);
            });
        }

    }
}
