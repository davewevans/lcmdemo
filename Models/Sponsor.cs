using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace LCMSMSPWA.Models
{
    public class Sponsor
    {
        // C:\Users\davew\source\repos\LCMSMSPWA\LCMSMSPWA\Models\Sponsor.cs
        // TODO: What about sponsors in foreign countries?
        // We need to allow for entering addresses with no state.

        public int SponsorID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName { get; set; } = string.Empty;

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        //[Email(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        //[Phone(ErrorMessage = "Invalid phone number.")]
        public string MainPhone { get; set; }

        public DateTime EntryDate { get; set; }
     
        public List<OrphanSponsor> OrphanSponsors { get; set; }
    }
}