using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class NarrationRepository : INarrationRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "narrations";

        public NarrationRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task AddNarrationAsync(NarrationCreation newNarration)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }";
            var response = await httpService.Post(url, newNarration);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateNarrationAsync(int narrationId, NarrationEdit narrationEdit)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ narrationId }";
            var response = await httpService.Put(url, narrationEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteNarrationAsync(int narrationId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ narrationId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<List<Narration>> GetOrphanNarrations(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ "orphan" }/{ orphanId }";
            var response = await httpService.Get<List<Narration>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Narration>> GetGuardianNarrations(int guradianId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ "guardian" }/{ guradianId }";
            var response = await httpService.Get<List<Narration>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
    }
}