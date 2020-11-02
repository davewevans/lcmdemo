using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMSMSPWA.Helpers;

namespace LCMSMSPWA.Services
{
    public interface IHttpService
    {
        Task<T> Get<T>(string uri, bool includeToken);
        
        Task<T> Post<T>(string uri, object value, bool includeToken);
        
        Task<T> Put<T>(string uri, object value, bool includeToken);
        
        Task<T> Patch<T>(string uri, object value, bool includeToken);
        
        Task<T> Delete<T>(string uri, object value, bool includeToken);
    }

    public class HttpService : IHttpService
    {
        private readonly HttpClientWithToken httpClientWithToken;
        private readonly HttpClientWithoutToken httpClientWithoutToken;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private IConfiguration _configuration;
        
        private JsonSerializerOptions defaultJsonSerializerOptions =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public HttpService(
            HttpClientWithToken httpClientWithToken,
            HttpClientWithoutToken httpClientWithoutToken,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService,
            IConfiguration configuration
        )
        {
            this.httpClientWithToken = httpClientWithToken;
            this.httpClientWithoutToken = httpClientWithoutToken;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
            _configuration = configuration;
        }

        private HttpClient GetHttpClient(bool includeToken = true)
        {
            return includeToken ? httpClientWithToken.HttpClient : httpClientWithoutToken.HttpClient;
        }
        
        public async Task<T> Get<T>(string uri, bool includeToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            return await sendRequest<T>(request, includeToken);
        }

        public async Task<T> Post<T>(string uri, object value, bool includeToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await sendRequest<T>(request, includeToken);
        }
        
        public async Task<T> Put<T>(string uri, object value, bool includeToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await sendRequest<T>(request, includeToken);
        }
        
        public async Task<T> Patch<T>(string uri, object value, bool includeToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Patch, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await sendRequest<T>(request, includeToken);
        }
        
        public async Task<T> Delete<T>(string uri, object value, bool includeToken)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, uri);
            request.Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json");
            return await sendRequest<T>(request, includeToken);
        }

        private async Task<T> sendRequest<T>(HttpRequestMessage request, bool includeToken)
        {
            var httpClient = GetHttpClient(includeToken);
            
            // add jwt auth header if user is logged in and request is to the api url
            // var user = await _localStorageService.GetItem<User>("user");
            // var isApiUrl = !request.RequestUri.IsAbsoluteUri;
            
            // if (user != null && isApiUrl)
            //     request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", user.Token);

            using var response = await httpClient.SendAsync(request);

            // auto logout on 401 response
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                _navigationManager.NavigateTo("logout");
                return default;
            }

            // throw exception on error response
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(error["message"]);
            }

            return await response.Content.ReadFromJsonAsync<T>();
        }
        
        private async Task<T> Deserialize<T>(HttpResponseMessage httpResponse, JsonSerializerOptions options)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, options);
        }
    }
}