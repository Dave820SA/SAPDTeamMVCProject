using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieBusinessLayer;

namespace SAPDMVCTeatProject.Controllers
{
    public class HomeController : Controller
    {
        MovieContext db = new MovieContext();
        public ActionResult Index()
        {

            string movie = (from m in db.Movies
                            orderby m.Price descending
                            select m.Title).FirstOrDefault();
            ViewBag.HighestPrice = movie;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}