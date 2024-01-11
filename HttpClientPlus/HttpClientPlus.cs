﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IMustafa
{

    public partial class HttpClientPlus : IDisposable
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

        private readonly HttpClientPlusOption _config;
        private readonly HttpClient _httpClient;
        public HttpClientPlus(HttpClientPlusOption config)
        {
            _config = config;
            _httpClient = new HttpClient();

            //set default headers
            if (_config.DefaultHeaders != null)
                this.setHeaders(_config.DefaultHeaders);

        }

        private void setHeaders(string key, string value)
        {
            _httpClient.DefaultRequestHeaders.Add(key, value);
        }

        private void setHeaders(Dictionary<string, string> headers)
        {
            foreach (var item in headers)
            {
                this.setHeaders(item.Key, item.Value);
            }
        }

        private async Task<TResponse?> coreAsync<TResponse>(Func<Task<TResponse>> action)
            where TResponse : class
        {

            TResponse? response = null;

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


        public void Dispose()
        {
            _httpClient?.Dispose();
        }

    }

}

