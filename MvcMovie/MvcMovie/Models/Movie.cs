using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        //标题
        [Display(Name ="标题")]
        public string Title { get; set; }


        [Display(Name = "发布日期")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        //发布日期
        public DateTime ReleaseDate { get; set; }
        //类别
        [Display(Name ="类别")]
        public string Genre { get; set; }
        //价格
        [Display(Name = "价格")]
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}