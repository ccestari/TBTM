using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TakeBackTheMusic.Models
{
    //public class Locations
    //{
    //}

    public class Countries
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string Country2ISO { get; set; }
        public string Country3ISO { get; set; }
        public DateTime CountryLastUpdated { get; set; }
    }
}
