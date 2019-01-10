using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    [Bind(Exclude = "AlbumId")]
    public class Album
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }
        [DisplayName("类型")]
        public int GenreId { get; set; }
        [DisplayName("艺术家")]
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "需要专辑标题")]
        [StringLength(160)]
        [Display(Name ="标题")]
        public string Title { get; set; }
        [Range(0.01, 100.00,
            ErrorMessage = "价格必须介于0.01和100.00之间")]
        public decimal Price { get; set; }
        [DisplayName("专辑艺术网址")]
        [StringLength(1024)]
        public string AlbumArtUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}