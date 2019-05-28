using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TakeBackTheMusic.Models
{
    public class Venues
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VenueID { get; set; }
        public string VenueName { get; set; }
        public bool IsVerified { get; set; }
    }

    public class VenueAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VenueAddressID { get; set; }
        public Venues VenueID { get; set; }
        public string VenueAddress1 { get; set; }
        public string VenueAddress2 { get; set; }
        public string VenueCity { get; set; }
        public string VenueState { get; set; }
        public string VenuePostal { get; set; }
        public Countries VenueCountry { get; set; }
    }
}
