using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "应用程序描述页面";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "你的联系页面";

            return View();
        }
    }
}