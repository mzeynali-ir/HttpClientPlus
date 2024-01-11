using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IMustafa
{
    public class HttpClientPlusConfig
    {
        public virtual Task BeforeExecuteAsync() => Task.CompletedTask;
        public virtual Task AfterExecuteAsync(HttpResponseMessage response) => Task.CompletedTask;
        public virtual Task WhenHasErrorAsync() => Task.CompletedTask;
        public virtual Task FinalAsync() => Task.CompletedTask;
    }

    public class HttpClientPlus : IDisposable
    {
        public Uri BaseAddress
        {
            get => _httpClient.BaseAddress;
            set => _httpClient.BaseAddress = value;
        }
        public long MaxResponseContentBufferSize
        {
            get => _httpClient.MaxResponseContentBufferSize;
            set => _httpClient.MaxResponseContentBufferSize = value;
        }
        public TimeSpan Timeout
        {
            get => _httpClient.Timeout;
            set => _httpClient.Timeout = value;
        }
        public HttpRequestHeaders DefaultRequestHeaders { get => _httpClient.DefaultRequestHeaders; }

        private readonly HttpClientPlusConfig _config;
        private readonly HttpClient _httpClient;
        public HttpClientPlus(HttpClientPlusConfig config)
        {
            _config = config;
            _httpClient = new HttpClient();
        }


        private async Task<HttpResponseMessage?> coreAsync(Func<Task<HttpResponseMessage>> action)
        {

            HttpResponseMessage? response = null;

            await _config.BeforeExecuteAsync();

            try
            {
                response = await action();

                await _config.AfterExecuteAsync(response);
            }
            catch (Exception ex)
            {
                await _config.WhenHasErrorAsync();
            }
            finally
            {
                await _config.FinalAsync();
            }

            return response;

        }

        public Task<HttpResponseMessage?> PostAsync(string requestUri, HttpContent content)
        {

            return this.coreAsync(() =>
            {
                return _httpClient.PostAsync(requestUri, content);
            });

        }

        public Task<HttpResponseMessage?> GetAsync(string requestUri)
        {

            return this.coreAsync(() =>
            {
                return _httpClient.GetAsync(requestUri);
            });

        }

        public Task<HttpResponseMessage?> DeleteAsync(string requestUri)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.DeleteAsync(requestUri);
            });
        }

        public Task<HttpResponseMessage?> PatchAsync(string requestUri, HttpContent content)
        {
            return this.coreAsync(() =>
            {
                return _httpClient.PatchAsync(requestUri, content);
            });
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }

    }
}

