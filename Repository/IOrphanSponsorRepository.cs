using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Repository
{
    public interface IOrphanSponsorRepository
    {
        Task AddAssignment(OrphanSponsor orphanSponsor);

        Task RemoveAssignment(OrphanSponsor orphanSponsor);
    }
}