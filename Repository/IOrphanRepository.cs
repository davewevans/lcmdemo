using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LCMSMSPWA.Models;

namespace LCMSMSPWA.Repository
{
    public interface IOrphanRepository
    {
        Task<List<Orphan>> GetAllOrphansAsync();

        Task<OrphansResponse> GetOrphansAsync(OrphanParametes parameters);

        Task<OrphanDetailsModel> GetOrphanDetailsAsync(int orphanId);
        
        Task<Guardian> GetOrphanGuardianAsync(int orphanId);

        Task<List<Sponsor>> GetOrphanSponsorsAsync(int orphanId);

        Task<List<Picture>> GetOrphanPicturesAsync(int orphanId);

        Task<List<PDF>> GetOrphanPDFsAsync(int orphanId);
        
        Task AddOrphanAsync(OrphanCreation newOrphan);

        Task UpdateOrphanAsync(int orphanId, OrphanEdit orphanEdit);

        Task PatchOrphanAsync(int orphanId, string propertyName, string newValue=null);

        Task DeleteOrphanAsync(int orphanId);
    }
}
