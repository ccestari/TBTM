using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TakeBackTheMusic.Areas.Identity.Data;

namespace TakeBackTheMusic.Models
{
    public class Venues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VenueID { get; set; }

        [Required]
        [Display(Name = "Venue Name")]
        public string VenueName { get; set; }

        public bool IsVerified { get; set; }

        public bool IsEmployeeConfirmed { get; set; }
    }

    public class VenueAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VenueAddressID { get; set; }

        public Venues VenueID { get; set; }

        [Display(Name = "Address 1")]
        public string VenueAddress1 { get; set; }

        [Display(Name = "Address 2")]
        public string VenueAddress2 { get; set; }

        [Display(Name = "City")]
        public string VenueCity { get; set; }

        [Display(Name = "State/Province")]
        public string VenueState { get; set; }

        [Display(Name = "Postal Code")]
        public string VenuePostal { get; set; }

        [Display(Name = "Country")]
        public Countries VenueCountry { get; set; }
    }
    
    public class VenueDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VenueDetailId { get; set; }

        public Venues VenueID { get; set; }

        public TakeBackTheMusicUser VenueOwnerId { get; set; }

        public bool OwnerVerified { get; set; }

        public bool OwnerReviewed { get; set; }

        public PhoneAttribute VenuePhone1 { get; set; }

        public PhoneAttribute VenuePhone2 { get; set; }

        public PhoneAttribute VenueFax { get; set; }


    }
}
