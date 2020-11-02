using System;
using System.Collections.Generic;

namespace LCMSMSPWA.Models
{
    public class Orphan
    {
        public int OrphanID { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        
        public string Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string LCMStatus { get; set; }

        public string ProfileNumber { get; set; }

        public DateTime EntryDate { get; set; }

        public int? GuardianID { get; set; }

        public int? ProfilePictureID { get; set; }

        public Picture ProfilePic { get; set; }

        public string ProfilePicUrl => ProfilePic != null ? $"{ ProfilePic?.BaseUrl }{ ProfilePic?.PictureFileName }" : "https://lcmsmsphotostorage.blob.core.windows.net/lcmsmsblobdemo/no_image_found_300x300.jpg";
     
        public List<Picture> Pictures { get; set; }

        public override string ToString()
        {
            return $"{ FirstName } { MiddleName } { LastName } { Gender } { DateOfBirth:d} { LCMStatus } { ProfileNumber }";
        }
    }
}

