using System.Net.Http;

namespace LCMSMSPWA.Helpers
{
    public class HttpClientWithToken
    {
        public HttpClient HttpClient { get; }


        public HttpClientWithToken(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    }
}