using KB.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KB.Controllers
{
    public class HomeController : Controller
    {
        KBDB _db = new KBDB();
        
        public ActionResult Index()
        {
            ViewBag.Message = "Artiklar";
            var model = _db.Articles.Include("Author").Include("Category").ToList();
            return View(model);
        }
        public ActionResult Article(int id)
        {
            var model = _db.Articles.FirstOrDefault(a => a.Id == id);
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
