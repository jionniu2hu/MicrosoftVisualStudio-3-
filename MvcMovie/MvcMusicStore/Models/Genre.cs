using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        [Display(Name ="名字")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}