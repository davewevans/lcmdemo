// using Syncfusion.Blazor;
// using Syncfusion.Blazor.Data;
// using LCMSMSPWA.HttpRepository;
// using LCMSMSPWA.Models;
// using Microsoft.AspNetCore.Components;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace LCMSMSPWA.Adaptors
// {
//     public class OrphanCustomAdaptor : DataAdaptor
//     {  
//         public IOrphanHttpRepository OrphanRepo { get; set; }

//         OrphanParametes parameters;

//         OrphansResponse response;

//         IEnumerable<Orphan> DataSource;

//         bool gridInitialized = false;  

//         public OrphanCustomAdaptor(IOrphanHttpRepository orphanRepo) 
//         {
//             parameters = new OrphanParametes();
//             response = new OrphansResponse();
//             OrphanRepo = orphanRepo;
//         }   


//         // Performs data Read operation
//         public override async Task<object> ReadAsync(DataManagerRequest dm, string key = null)
//         {            
//             if (!gridInitialized)
//             {
//                 dm.Take = parameters.PageSize;
//                 response = await OrphanRepo.GetOrphansAsync(parameters);
//                 DataSource = response.Orphans;
//                 gridInitialized = true;            
//             } 

//             parameters.PageNumber = response.MetaData.PageNumber;
//             parameters.PageSize = response.MetaData.PageSize;         

//             if (dm.Search != null && dm.Search.Count > 0)
//             {
//                 // Searching
//                 DataSource = DataOperations.PerformSearching(DataSource, dm.Search);
//             }
//             if (dm.Sorted != null && dm.Sorted.Count > 0)
//             {
//                 // Sorting
//                 DataSource = DataOperations.PerformSorting(DataSource, dm.Sorted);
//             }
//             if (dm.Where != null && dm.Where.Count > 0)
//             {
//                 // Filtering
//                 DataSource = DataOperations.PerformFiltering(DataSource, dm.Where, dm.Where[0].Operator);
//             }

//             int count = response.MetaData != null ? response.MetaData.TotalCount : DataSource.Cast<Orphan>().Count();
        
//             if (dm.Take != 0)
//             {               
//                 parameters.PageSize = dm.Take;
//                 parameters.PageNumber = (dm.Skip / parameters.PageSize) + 1;

//                 response = await OrphanRepo.GetOrphansAsync(parameters);
//                 DataSource = response.Orphans;
//             }
//             return dm.RequiresCounts ? new DataResult() { Result = DataSource, Count = count } : (object)DataSource;
//         }      
//         public override async Task<object> InsertAsync(DataManager dm, object value, string key)
//         {
//             var orphan = value as Orphan;
//             var newOrphan = new OrphanCreation {
//                 FirstName = orphan.FirstName,
//                 MiddleName = orphan.MiddleName,
//                 LastName = orphan.LastName,
//                 Gender = orphan.Gender,
//                 DateOfBirth = orphan.DateOfBirth,
//                 LCMStatus = orphan.LCMStatus,
//                 ProfileNumber = orphan.ProfileNumber
//             };

//             await OrphanRepo.AddOrphanAsync(newOrphan);
//             return value;
//         }   

//         public override async Task<object> UpdateAsync(DataManager dm, object value, string keyField, string key)
//         {
//             var orphan = (value as Orphan);
//             var orphanUpdate = new OrphanEdit {
//                 FirstName = orphan.FirstName,
//                 MiddleName = orphan.MiddleName,
//                 LastName = orphan.LastName,
//                 Gender = orphan.Gender,
//                 DateOfBirth = orphan.DateOfBirth,
//                 LCMStatus = orphan.LCMStatus,
//                 ProfileNumber = orphan.ProfileNumber,
//                 EntryDate = orphan.EntryDate,
//                 ProfilePictureID = orphan.ProfilePictureID,
//                 GuardianID = orphan.GuardianID
//             };
//             await OrphanRepo.UpdateOrphanAsync(orphan.OrphanID, orphanUpdate);
//             return value;
//         }  

//         public override async Task<object> RemoveAsync(DataManager dm, object value, string keyField, string key)
//         {            
//             int orphanId;  
//             if (int.TryParse(value.ToString(), out orphanId)) {
//                 await OrphanRepo.DeleteOrphanAsync(orphanId); 
//             }       
//             return value;
//         }  
    
//     }
// }
