using System.Net.Http;

namespace LCMSMSPWA.Helpers
{
    public class HttpClientWithoutToken
    {
        public HttpClient HttpClient { get; }

        public HttpClientWithoutToken(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    }
}