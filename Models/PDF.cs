using System;

namespace LCMSMSPWA.Models
{
    public class PDF
    {
        public int DocumentID { get; set; }
        
        public string FileName { get; set; }

        public Sponsor Sponsor { get; set; }

        public int OrphanID { get; set; }

        public int SponsorID { get; set; }   
        
        public string BaseUrl { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}