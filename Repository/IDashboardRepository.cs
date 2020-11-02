using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Repository
{
    public interface IDashboardRepository
    {
        Task<TotalCounts> GetTotalCounts();
        
        Task<OrphanStatistics> GetOrphanStatistics();

        Task<NarrationStatistics> GetNarrationStatistics();
    }
}