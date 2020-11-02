using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Repository
{
    public interface ISponsorRepository
    {
        Task<List<Sponsor>> GetSponsorsAsync();
        
        Task<Sponsor> GetSponsorAsync(int sponsorId);

        Task AddSponsorAsync(SponsorCreation newSponsor);

        Task UpdateSponsorAsync(int sponsorId, SponsorEdit sponsor);

        Task DeleteSponsorAsync(int sponsorId);
    }
}