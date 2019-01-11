﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Genre
    {
        public int GenreID { get; set; }

        [Display(Name = "流派名字")]
        public string GenreName { get; set; }

        [Display(Name = "信息")]
        public virtual ICollection<Info> Info { get; set; }

        [Display(Name = "音乐")]
        public virtual ICollection<Music> Musics { get; set; }
    }
}
