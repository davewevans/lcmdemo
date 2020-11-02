using System;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using LCMSMSPWA.Services;

namespace LCMSMSPWA.Repository
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly IHttpService httpService;
        private const string Controller = "dashboard";

        public DashboardRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }
        
        public async Task<TotalCounts> GetTotalCounts()
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/totalCounts";
            var response = await httpService.Get<TotalCounts>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<OrphanStatistics> GetOrphanStatistics()
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/orphanStats";
            var response = await httpService.Get<OrphanStatistics>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        
        public async Task<NarrationStatistics> GetNarrationStatistics()
        {
            string url = $"{ httpService.BaseAddress }/{ Controller }/narrationStats";
            var response = await httpService.Get<NarrationStatistics>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

    }
}