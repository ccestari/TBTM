using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TakeBackTheMusic.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [StringLength(50)]
        public string GenreName { get; set; }
        [StringLength(256)]
        public string GenreDescription { get; set; }
        public DateTime GenreDateAdded { get; set; }
        public DateTime GenreUpdatedDate { get; set; }
    }
}
