using System.Net.Http.Headers;

namespace IMustafa
{
    public partial class HttpClientPlus
    {

        /// <summary>
        /// set 'Content-Type'
        /// </summary>
        /// <param name="contentType">MIME types</param>
        public void SetContentType(ContentType contentType)
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(contentType.Value));
        }

    }
}

