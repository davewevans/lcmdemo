using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;

namespace LCMSMSPWA.Components
{
    public partial class OrphanTable
    {
        [Parameter]
        public List<Orphan> Orphans { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void ViewDetails(int id)
        {
            var orphan = Orphans.SingleOrDefault(x => x.OrphanID == id);
            if (orphan != null)
            {
                NavigationManager.NavigateTo($"/orphandetails/{ id }");
            }           
        }

        public void NavigateToHome()
        {
            NavigationManager.NavigateTo("/");
        }


    }
}
