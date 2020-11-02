using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class GuardianRepository : IGuardianRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "guardians";

        public GuardianRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        
        public async Task<List<Guardian>> GetGuardiansAsync()
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }";
            var response = await httpService.Get<List<Guardian>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<Guardian> GetGuardianAsync(int guardianId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ guardianId }";
            var response = await httpService.Get<Guardian>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task AddGuardianAsync(GuardianCreation newGuardian)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }";
            var response = await httpService.Post(url, newGuardian);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateGuardianAsync(int guardianId, GuardianEdit guardianEdit)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{guardianId}";
            var response = await httpService.Put(url, guardianEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteGuardianAsync(int guardianId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ guardianId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}