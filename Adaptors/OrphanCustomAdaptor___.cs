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
        
//         private IEnumerable<Orphan> DataSource = new List<Orphan>();

//         bool gridInitialized = false;

//         public OrphanCustomAdaptor(IOrphanHttpRepository orphanRepo) 
//         {
//             OrphanRepo = orphanRepo;
//         }  

//         // Performs data Read operation
//         public override async Task<object> ReadAsync(DataManagerRequest dm, string key = null)
//         {    
//             if (!gridInitialized)
//             {
//                 DataSource = await OrphanRepo.GetAllOrphansAsync();
//                 gridInitialized = true;            
//             }         

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

//             int count = DataSource.Cast<Orphan>().Count();

//             if (dm.Skip != 0)
//             {
//                 DataSource = DataSource.Skip(dm.Skip); //Paging
//             }       
        
//             if (dm.Take != 0)
//             {               
//                 DataSource = DataSource.Take(dm.Take);
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
