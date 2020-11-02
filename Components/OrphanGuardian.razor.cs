using System;
using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using LCMSMSPWA.Repository;
using LCMSMSPWA.enums;
using MatBlazor;

namespace LCMSMSPWA.Components
{
    public partial class OrphanGuardian
    { 
        [Parameter]
       public OrphanDetailsModel Orphan { get; set; }
       
       [Parameter]
       public EventCallback HandleOrphanEdited { get; set; }
       
       [Inject]
       public IOrphanRepository OrphanRepository { get; set; }
       
       protected SfConfirmDeleteDialog DeleteConfirmationDialog { get; set; }

       private ViewMode viewMode = ViewMode.List;

       private int counter = 0;

       private void OnAddClick()
       {
           viewMode = ViewMode.AddNew;
       }

       public async Task OnAddNewComplete(bool recordAdded)
       {
           viewMode = ViewMode.List;
           if (recordAdded)
           {
               Orphan.Guardian = await OrphanRepository.GetOrphanGuardianAsync(Orphan.OrphanID);
               StateHasChanged();
               
               await HandleOrphanEdited.InvokeAsync("");
           }
       }
       private void OnRemoveClick()
       {
           DeleteConfirmationDialog.ShowDialog();
       }
    
       protected async Task OnConfirmDelete(bool deleteConfirmed)
       {
           if (deleteConfirmed)
           {
               await OrphanRepository.PatchOrphanAsync(Orphan.OrphanID, "guardianID");
               Orphan.Guardian = await OrphanRepository.GetOrphanGuardianAsync(Orphan.OrphanID);
               StateHasChanged();  
               
               await HandleOrphanEdited.InvokeAsync("");
                             
           }
       }
    }
}
