using LCMSMSPWA.Repository;
using LCMSMSPWA.Models;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMSMSPWA.Components
{
    public partial class OrphanProfileEdit
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }
        
        [Parameter]
        public EventCallback<OrphanDetailsModel> HandleOrphanEdited { get; set; }

        [Inject]
        protected IMatToaster Toaster { get; set; }

        [Inject]
        public IOrphanRepository OrphanRepo { get; set; }

        private async Task HandleValidSubmit()
        {
            var orphanEdit = new OrphanEdit
            {
                FirstName = Orphan.FirstName,
                MiddleName = Orphan.MiddleName,
                LastName = Orphan.LastName,
                DateOfBirth = Orphan.DateOfBirth,
                Gender = Orphan.Gender,
                LCMStatus = Orphan.LCMStatus,
                ProfileNumber = Orphan.ProfileNumber,
                GuardianID = Orphan.GuardianID,
                EntryDate = Orphan.EntryDate,
                ProfilePictureID = Orphan.ProfilePictureID
            };

            await OrphanRepo.UpdateOrphanAsync(Orphan.OrphanID, orphanEdit);
            Toaster.Add("Record updated.", MatToastType.Success);
            
            
            await HandleOrphanEdited.InvokeAsync(Orphan);
        }

        private async Task HandleProfileChanged(OrphanDetailsModel orphan)
        {
            // StateHasChanged(); invoked auto
            await HandleOrphanEdited.InvokeAsync(Orphan);
        }
    }
}
