using Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Back.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Vote";

            return View();
        }

        public ActionResult Results()
        {
            CatmashContext db = new CatmashContext();

            ViewBag.Title = "Results";
            var Model = db.Cats.OrderByDescending(x => x.Elo).ToList();
            return View(Model);
        }
    }
}
