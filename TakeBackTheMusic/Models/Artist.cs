using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using TakeBackTheMusic.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace TakeBackTheMusic.Models 
{
    public class Artist 
    {
        public int ArtistID { get; set; }

        //public int ArtistCreator { get; set; }
        public TakeBackTheMusicUser OwnerID { get; set; }
        //public string OwnerID { get; set; }

        public DateTime ArtistCreateDate { get; set; }

        [Required()]
        [StringLength(150)]
        public string ArtistDisplayName { get; set; }

        [Required]
        [StringLength(150)]
      //  [index(IsUnique = true)]
        public string ArtistLink { get; set; }

        public string ArtistDesc { get; set; }

        public bool IsPublic { get; set; }
    }

    public class ArtistGenres
    {
        [Key]
        public int ArtistGenreID { get; set; }
        public Artist ArtistID { get; set; }
        //public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public bool IsPrimary { get; set; }
        public int GenreRank { get; set; }

    }

}
