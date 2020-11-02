using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using LCMSMSPWA.Validations;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Newtonsoft.Json;

namespace LCMSMSPWA.Models
{
    public class Picture
    {       
        public int PictureID { get; set; }

        //[FileSizeValidator(MaxFileSizeInMbs: 4)]
        //[ContentTypeValidator(ContentType.Image)]
        //public IFormFile Picture { get; set; }

        public string PictureFileName { get; set; }
        public string BaseUrl { get; set; }

        public bool SetAsProfilePic { get; set; }

        public string Caption { get; set; }

        public DateTime CreatedAt { get; set; }

        public int OrphanID { get; set; }
    }
}