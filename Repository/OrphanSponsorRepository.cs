using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class OrphanSponsorRepository : IOrphanSponsorRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "orphanssponsors";

        public OrphanSponsorRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        
        public async Task AddAssignment(OrphanSponsor orphanSponsor)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/assignSponsor";
            var response = await httpService.Post(url, orphanSponsor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task RemoveAssignment(OrphanSponsor orphanSponsor)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/removeSponsor";
            var response = await httpService.Post(url, orphanSponsor);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}