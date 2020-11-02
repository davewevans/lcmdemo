using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class PDFRepository : IPDFRepository
    {
        private readonly IHttpService httpService;
        private readonly HttpClient httpClient;

        private const string Controller = "documents";

        public PDFRepository(IHttpService httpService, HttpClient httpClient)
        {
            this.httpService = httpService;
            this.httpClient = httpClient;
        }
        
        public async Task<string> UploadPDFAsync(PDFCreation pdfCreation, byte[] fileBytes)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }";

            await using MemoryStream fileStream = new MemoryStream(fileBytes);

            // Create the content
            var content = new MultipartFormDataContent();
            content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");

            var jsonData = JsonSerializer.Serialize<PDFCreation>(pdfCreation, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            content.Add(new StringContent(jsonData, Encoding.UTF8, "application/json"));
            content.Add(new StreamContent(fileStream, (int)fileStream.Length), "file", pdfCreation.FileName);
            
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
        
        public async Task DeletePDFAsync(int pdfID)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ pdfID }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}