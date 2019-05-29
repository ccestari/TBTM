using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TakeBackTheMusic.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace TakeBackTheMusic.Models 
{
    public class Photos
    {
        [Key]
        public Guid PhotoID { get; set; }

        public TakeBackTheMusicUser PhotoOwnerID { get; set; }


        public string PhotoFilePath { get; set; }

        [Display(Name = "Caption")]
        public string PhotoCaption { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public DateTime PhotoUploadTime { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public DateTime LastUpdated { get; set; }

        [ScaffoldColumn(false)]
        public bool IsDelete { get; set; }
    }

    public class PhotoTags
    {
        [Key]
        public Guid PhotoTagID { get; set; }

        public Photos PhotoID { get; set; }

        [Display(Name = "Tag People")]
        public TakeBackTheMusicUser TaggedUser { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public DateTime TagAddedTime { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public DateTime TagLastUpdated { get; set; }
    }

    public class PhotoLocations
    {
        [Key]
        public Guid PhotoLocationID { get; set; }

        public Photos PhotoID { get; set; }

        public Countries Country { get; set; }

        public string State { get; set; }
        public string City { get; set; }
        public string Landmark { get; set; }

        // Add below geolocation capability when ready using https://www.markopapic.com/finding-nearby-users-using-ef-core-spatial-data/
        // public Point GeoCode { get; set; }
    }

    public class PhotoComments
    {
        [Key]
        public Guid CommentID { get; set; }
        public TakeBackTheMusicUser PhotoCommentorID { get; set; }

        [ScaffoldColumn(false)]
        public Photos PhotoID { get; set; }

        [Display(Name = "Caption")]
        public string PhotoComment { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public DateTime PhotoCommentCreateTime { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public DateTime LastUpdated { get; set; }

        [ScaffoldColumn(false)]
        public bool IsDelete { get; set; }
    }

    public class PhotoFlags
    {
        [Key]
        public Guid PhotoFlagID { get; set; }

        [ScaffoldColumn(false)]
        public Photos PhotoID { get; set; }

        [ScaffoldColumn(false)]
        public TakeBackTheMusicUser PhotoFlaggerID { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public DateTime FlagDate { get; set; }

        [ScaffoldColumn(false)]
        public bool UserReversed { get; set; }

        [ScaffoldColumn(false)]
        public bool EmployeeReviewed { get; set; }

        public PhotoFlagReason Reason { get; set; }

        [Display(Name = "Other Reason for flagging")]
        public string ReasonOther { get; set; }
    }

    public enum PhotoFlagReason
    {
        Nudity,
        Violence,
        Racism,
        Other
    }

   // public class dbset<>
}
