using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LCMSMSPWA.Repository;

namespace LCMSMSPWA.Components
{
    public partial class OrphanPictures
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }

        [Inject] public IOrphanRepository OrphanRepository { get; set; }

        private async Task HandlePostUpload(OrphanDetailsModel orphan)
        {
            Orphan.Pictures = await OrphanRepository.GetOrphanPicturesAsync(Orphan.OrphanID);
            StateHasChanged();
        }
    }
}
