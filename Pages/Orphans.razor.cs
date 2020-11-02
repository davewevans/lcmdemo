using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCMSMSPWA.Repository;
using LCMSMSPWA.Models;
using LCMSMSPWA.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace LCMSMSPWA.Pages
{
    public partial class Orphans
    {
        public List<Orphan> OrphansList { get; set; } = new List<Orphan>();

        [Inject]
        public IOrphanRepository OrphanRepo { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //var response = await OrphanRepo.GetOrphansAsync();
            //OrphansList = response.Orphans;

            //just for testing
            //foreach (var orphan in OrphansList)
            //{
            //    Console.WriteLine(orphan.OrphanID);
            //    Console.WriteLine(orphan.FullName);

            //    Debug.WriteLine(orphan.OrphanID);                
            //    Debug.WriteLine(orphan.FullName);
            //}

            // return base.OnInitializedAsync();
        }

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
        }
        protected override Task OnParametersSetAsync()
        {
            return base.OnParametersSetAsync();
        }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void NavigateToHome()
        {
            NavigationManager.NavigateTo("/");
        }

        public void CreateNewOnClick()
        {
            NavigationManager.NavigateTo("/CreateOrphan");
        }

    }
}
