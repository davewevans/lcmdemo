using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class AcademicRepository : IAcademicRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "academics";

        public AcademicRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Academic>> GetOrphanAcademics(int orphanId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/orphan/{ orphanId }";
            var response = await httpService.Get<List<Academic>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task AddAcademicAsync(AcademicCreation newAcademic)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }";
            var response = await httpService.Post(url, newAcademic);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateAcademicAsync(int academicId, AcademicEdit academicEdit)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{academicId}";
            var response = await httpService.Put(url, academicEdit);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteAcademicAsync(int academicId)
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/{ academicId }";
            var response = await httpService.Delete(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}