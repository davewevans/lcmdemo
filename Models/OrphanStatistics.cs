using System;

namespace LCMSMSPWA.Models
{
    public class OrphanStatistics 
    {
        public int ActiveCount { get; set; }

        public int InactiveCount { get; set; }

        public int UnknownCount { get; set; }

        public int TotalCount { get; set; }

        public string ActiveCountText => $"{(ActiveCount / TotalCount) * 100 }%";

        public string InactiveCountText => $"{(InactiveCount / TotalCount) * 100 }%";
        
        public string UnknownCountText => $"{(UnknownCount / TotalCount) * 100 }%";
    } 
}