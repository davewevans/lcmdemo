using LCMSMSPWA.Components;
using LCMSMSPWA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class PictureRepository : IPictureRepository
    {
        private readonly IHttpService httpService;
        private readonly HttpClient httpClient;

        private const string Controller = "pictures";

        public PictureRepository(IHttpService httpService, HttpClient httpClient)
        {
            this.httpService = httpService;
            this.httpClient = httpClient;
        }

        public async Task<string> UploadImageAsync(PictureCreation picCreation, byte[] fileBytes)
        {        
            string url = $"{ httpService.BaseAddress }/{ Controller }";

            await using MemoryStream fileStream = new MemoryStream(fileBytes);

            // Create the content
            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

            var jsonData = JsonSerializer.Serialize<PictureCreation>(picCreation, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            content.Add(new StringContent(jsonData, Encoding.UTF8, "application/json"));
            content.Add(new StreamContent(fileStream, (int)fileStream.Length), "file", picCreation.PictureFileName);
            
            //
            // TODO use http service instead
            // not working for now; need to figure out why
            //
            var response = await httpClient.PostAsync(url, content);
            // var response = await httpService.Post(url, content);
            
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadAsStringAsync();
        }
    }
}
