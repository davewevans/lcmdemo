
using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Repository 
{
    public interface INarrationRepository
    {    
        Task AddNarrationAsync(NarrationCreation newNarration);

        Task UpdateNarrationAsync(int narrationId, NarrationEdit narrationEdit);

        Task DeleteNarrationAsync(int narrationId);

        Task<List<Narration>> GetOrphanNarrations(int orphanId);

        Task<List<Narration>> GetGuardianNarrations(int guradianId);
    }
}



