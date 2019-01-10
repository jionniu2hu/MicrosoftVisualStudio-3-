using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        // GET: /Store/
        public ActionResult Index()
        {
            //var genres = storeDB.Genres.ToList();
            //return View(genres);
            var example = storeDB.Genres.Single(g => g.Name == "迪斯科");
            return View(example);
        }
        //
        // GET: /Store/Browse?genre=20
        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            var genreModel = storeDB.Genres.Include("专辑")
                .Single(g => g.Name == genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);

            return View(album);
        }
    }
}