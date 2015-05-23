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
            return Articles(null);
        }
        public ActionResult Article(int id)
        {
            var model = _db.Articles.Include("Author").Include("Category").FirstOrDefault(a => a.Id == id);
            return View(model);
        }
        public ActionResult Category(string category)
        {
            var model = _db.Articles.Where(a => a.Category.Name == category);
            return View();
        }
        public ActionResult Articles(string category)
        {
            if (category != null)
            {
                ViewBag.IsCategory = true;
                ViewBag.Category = category;
                var model = _db.Articles.Include("Author").Include("Category").Where(a => a.Category.Name == category);
                 return View(model);
            }
            else
            {
                ViewBag.IsCategory = false;
                
                var model = _db.Articles.Include("Author").Include("Category").ToList();
                return View(model);
            }
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
