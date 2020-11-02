using Microsoft.AspNetCore.Components;
using LCMSMSPWA.Models;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
//using System.Runtime.InteropServices;
//using System.Runtime.CompilerServices;
using LCMSMSPWA.Repository;
using LCMSMSPWA.Components;
//using System.Net.Cache;

namespace LCMSMSPWA.Pages
{

    public partial class OrphanDetails
    {
        string fullNameStyle = "bg-gray-200 p-2";
        static Random randomizer = new Random();
        string bgImageUrl = "images/bg-1.jpg";
        string profileBgClass = "bg-gradient-to-r from-orange-400 via-red-500 to-blue-500";
        string[] gradientColors = {"orange","pink","red","green","yellow","purple","blue","teal", "indigo","gray"};
        
        [Inject]
        public IJSRuntime Js { get; set; }

        [Inject]
        public IOrphanRepository OrphanRepo { get; set; }

        [Parameter]
        public int Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public OrphanDetailsModel Orphan { get; set; }

        protected ConfirmDelete DeleteConfirmation { get; set; }
        
        
        protected SfConfirmDeleteDialog DeleteConfirmationDialog { get; set; }

        public OrphanSummary Summary { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orphan = await OrphanRepo.GetOrphanDetailsAsync(Id);
            if (Orphan == null) return;
            
            Orphan.ProfilePicUrl = string.IsNullOrWhiteSpace(Orphan.ProfilePicUrl)
                ? "https://lcmsmsphotostorage.blob.core.windows.net/lcmsmsblobdemo/no_image_found_300x300.jpg"
                : Orphan.ProfilePicUrl;

            PopulateSummary();
            GenerateProfileBackground();
            SetNameBgColorBasedOnGender();
        }
        
        private void PopulateSummary()
        {
            Summary = new OrphanSummary
            {
                HasGuardian = Orphan.Guardian != null ? "Yes" : "No",
                HasGuardianStyle = Orphan.Guardian != null ? "text-green-700 font-semibold" : "text-red-700 font-semibold",
                NumOfSponsors = Orphan.Sponsors.Count(),
                Birthdate = Orphan.DateOfBirth,
                LCMStatus = Orphan.LCMStatus,
                LCMStatusStyle = Orphan.LCMStatus.ToLower().Equals("active") ? "px-2 inline-flex text-sm leading-5 font-semibold rounded-full bg-green-100 text-green-800" : "px-2 inline-flex text-sm leading-5 font-semibold rounded-full bg-red-100 text-red-800",
                ProfileNumber = Orphan.ProfileNumber
            };
        }

        private void GenerateProfileBackground()
        {
            //
            // Bg image doesn't display in full when running on Azure for some strange reason.
            // But it works locally! I got tired of fighting with it. So just bg gradients.
            //
            // bgImageUrl = $"images/bg-{ randomizer.Next(1,7) }.jpg";
            string randomGradientStyle = $"bg-gradient-to-r from-{gradientColors[randomizer.Next(gradientColors.Length)]}-400 via-{gradientColors[randomizer.Next(gradientColors.Length)]}-500 to-{gradientColors[randomizer.Next(gradientColors.Length)]}-500";
           // profileBgClass = randomizer.Next(2) == 0 ? "bg-image" : randomGradientStyle;
            profileBgClass = randomGradientStyle;
        }

        private void SetNameBgColorBasedOnGender()
        {
            if (Orphan.Gender.ToLower().Equals("male") || Orphan.Gender.ToLower().Equals("female"))
            {
                fullNameStyle = Orphan.Gender.ToLower().Equals("male") ? "bg-blue-200 p-2" : "bg-pink-200 p-2";
            }
        }
        
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
                     
        }

        protected void OnDeleteClick()
        { 
           DeleteConfirmationDialog.ShowDialog();
        }

        protected async Task OnConfirmDelete(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                await OrphanRepo.DeleteOrphanAsync(Orphan.OrphanID);
                NavigationManager.NavigateTo("/orphans");                
            }
        }
        
        public void HandleOrphanEdited()
        {
            //StateHasChanged();
            PopulateSummary();
            GenerateProfileBackground();
            SetNameBgColorBasedOnGender();
        }
    }
}
