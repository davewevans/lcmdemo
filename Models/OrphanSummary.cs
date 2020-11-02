using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Radzen;

namespace LCMSMSPWA.Models
{
    public class OrphanSummary
    {
        public string HasGuardian { get; set; }
        public string HasGuardianStyle { get; set; } 
        public int NumOfSponsors { get; set; }
        public DateTime? Birthdate { get; set; }
        public int Age { 
            get {
                if (Birthdate == null) return 0;
                DateTime birthdate = (DateTime) Birthdate;
                return (int)((DateTime.Today - birthdate).Days / 365.25);
            } 
        }
        public string BirthdayFormatted => Birthdate?.ToString("MMMM dd");
        public string LCMStatus { get; set; }

        public string LCMStatusStyle { get; set; }
        public string ProfileNumber { get; set; }
    }
}
