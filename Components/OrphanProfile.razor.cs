using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LCMSMSPWA.Components
{
    public partial class OrphanProfile
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }
        
        [Parameter]
        public EventCallback HandleOrphanEdited { get; set; }

        private bool editMode = false;

        private string editViewIcon = "fa fa-edit";

        private string editViewText = "Edit";

        public void ToggleEditMode()
        {
            editMode = !editMode;
            editViewIcon = editMode ? "fa fa-times" : "fa fa-edit";
            editViewText = editMode ? "Close" : "Edit";
        }

        public async Task HandleOrphanEditedByChild(OrphanDetailsModel orphan)
        {
            // StateHasChanged();
            await HandleOrphanEdited.InvokeAsync("");
        }
    }
}
