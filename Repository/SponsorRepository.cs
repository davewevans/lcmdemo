using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class SponsorRepository : ISponsorRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "sponsors";

        public SponsorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        
        public async Task<List<Sponsor>> GetSponsorsAsync()
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }";
            var response = await httpService.Get<List<Sponsor>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Sponsor> GetSponsorAsync(int sponsorId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ sponsorId }";
            var response = await httpService.Get<Sponsor>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;;
        }

        public async Task AddSponsorAsync(SponsorCreation newSponsor)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }";
            var response = await httpService.Post(url, newSponsor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateSponsorAsync(int sponsorId, SponsorEdit sponsorEdit)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{sponsorId}";
            var response = await httpService.Put(url, sponsorEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteSponsorAsync(int sponsorId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ sponsorId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}