using LCMSMSPWA.Repository;
using LCMSMSPWA.Models;
using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace LCMSMSPWA.Pages
{
    public partial class CreateOrphan
    {
        public OrphanCreation NewOrphan { get; set; } = new OrphanCreation();

        [Inject]
        protected IMatToaster Toaster { get; set; }

        [Inject]
        public IOrphanRepository OrphanRepo { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public void HandleValidSubmit()
        {
            OrphanRepo.AddOrphanAsync(NewOrphan);
            // NavigationManager.NavigateTo("/CreateOrphan");
            NewOrphan = new OrphanCreation();
            Toaster.Add($"{ NewOrphan.FirstName } added.", MatToastType.Success);
        }

        public void DatePickerChanged()
        {

        }

    }
}
