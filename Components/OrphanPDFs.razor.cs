using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCMSMSPWA.Repository;

namespace LCMSMSPWA.Components
{
    public partial class OrphanPDFs
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }
        
        private string selectedValue;

        [Inject] public IOrphanRepository OrphanRepository { get; set; }
        
        [Inject] public  IPDFRepository PdfRepository { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Orphan.PDFs = await OrphanRepository.GetOrphanPDFsAsync(Orphan.OrphanID);

            if (Orphan?.Sponsors == null) return;
            foreach (var sponsor in Orphan.Sponsors)
            {
                sponsor.FullName = $"{sponsor.FirstName} {sponsor.LastName} ({sponsor.Email})";
            }
        }

        private async Task HandlePostUpload(OrphanDetailsModel orphan)
        {
            Orphan.PDFs = await OrphanRepository.GetOrphanPDFsAsync(orphan.OrphanID);
            StateHasChanged();
        }

        private async Task OnDeletePDF(int id)
        {
            await PdfRepository.DeletePDFAsync(id);
            Orphan.PDFs = await OrphanRepository.GetOrphanPDFsAsync(Orphan.OrphanID);
            StateHasChanged();
        }
    }
}