using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMSMSPWA.Helpers;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class OrphanRepository : IOrphanRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "orphans";

        public OrphanRepository(
            IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Orphan>> GetAllOrphansAsync()
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/getAllOrphans";
            var response = await httpService.Get<List<Orphan>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<OrphansResponse> GetOrphansAsync(OrphanParametes parameters)
        {
            // string queryString = $"?pageSize={parameters.PageSize}&pageNumber={parameters.PageNumber}";
            // string url = $"{ httpService.BaseAddress }/{Controller}{queryString} ";
            //
            // var request = new HttpRequestMessage(HttpMethod.Get, url);
            //
            // // TODO Add JWT token to header
            // // request.Headers 
            //
            // var response = await httpClient.SendAsync(request);
            // try
            // {
            //     response.EnsureSuccessStatusCode();
            // }
            // catch (HttpRequestException ex)
            // {
            //     // TODO log exception
            // }
            //
            // IEnumerable<string> xPagination;
            // response.Headers.TryGetValues("X-Pagination", out xPagination);
            //
            // ResponseMetaData metaData = null;
            // if (xPagination != null)
            // {
            //     string xPaginationData = xPagination.FirstOrDefault();
            //     metaData = JsonSerializer.Deserialize<ResponseMetaData>(xPaginationData,
            //         new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            // }
            //
            // var content = await response.Content.ReadAsStringAsync();
            // var orphans = JsonSerializer.Deserialize<List<Orphan>>(content,
            //     new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            //
            // return new OrphansResponse {Orphans = orphans, MetaData = metaData};

            return null;
        }

        public async Task<OrphanDetailsModel> GetOrphanDetailsAsync(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var response = await httpService.Get<OrphanDetailsModel>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;

        }

        public async Task<Guardian> GetOrphanGuardianAsync(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/getOrphanGuardian/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<Guardian>(url);
            if (!response.Success)
            {
                // TODO throws 404 exception in browser
                //throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Sponsor>> GetOrphanSponsorsAsync(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/getOrphanSponsors/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<List<Sponsor>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Picture>> GetOrphanPicturesAsync(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/getOrphanPictures/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<List<Picture>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<List<PDF>> GetOrphanPDFsAsync(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/getOrphanPDFs/{orphanId}";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            
            var response = await httpService.Get<List<PDF>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task AddOrphanAsync(OrphanCreation newOrphan)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}";
            var response = await httpService.Post(url, newOrphan);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateOrphanAsync(int orphanId, OrphanEdit orphanEdit)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/{orphanId}";
            var response = await httpService.Put(url, orphanEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task PatchOrphanAsync(int orphanId, string propertyName, string newValue = null)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/{orphanId}";

            /*    JSON body example for patch request         
             [
                {
                    "value": "Smith",
                    "path": "/lastName",
                    "op": "replace"
                }
             ]
             */

            string json = "";
            if (newValue != null)
            {
                json = $"[{{\"value\": \"{newValue}\", \"path\": \"/{propertyName}\", \"op\": \"replace\"}}]";
            }
            else
            {
                json = $"[{{\"value\": {null}, \"path\": \"/{propertyName}\", \"op\": \"replace\"}}]";
            }
            
            var response = await httpService.Patch(url, json);
            
            if (!response.Success)
            {
                // TODO throws 404 exception in browser
               // throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteOrphanAsync(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{Controller}/{orphanId}";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        //
        // TODO
        // Update UpdateDb entity
        //
    }
}