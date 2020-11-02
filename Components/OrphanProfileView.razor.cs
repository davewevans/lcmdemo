using LCMSMSPWA.Models;
using Microsoft.AspNetCore.Components;
using LCMSMSPWA.Components;

namespace LCMSMSPWA.Components
{
    public partial class OrphanProfileView
    {
        [Parameter]
        public OrphanDetailsModel Orphan { get; set; }
    }
}
