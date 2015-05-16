using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KB.Models;
using KB.Db;
using KB.Enteties;

namespace KB.Controllers
{
    public class KBController : Controller
    {
        //
        // GET: /KB/
        KBDB _db = new KBDB();
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
               base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            var model = _db.Articles.ToList();
            return View(model);
        }

        //
        // GET: /KB/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /KB/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /KB/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                TryUpdateModel(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /KB/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /KB/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /KB/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /KB/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        /*
        static List<Article> ListOfArticles = new List<Article>{

            new Article{
                Id = 1001,
                Author = new Author("sebastian@regiondata.se", 1, "Sebastian"),
                Title = "First Article",
                Content = "This is the very first Article"
            },
            new Article{
                Id = 1002,
                Author = new Author("nils@regiondata.se", 2, "Nils"),
                Title = "Second Article",
                Content = "This is the second Article"
            },
            new Article{
                Id = 1003,
                Author = new Author("sebastian@regiondata.se", 1, "Sebastian"),
                Title = "Third Article",
                Content = "This is the third Article"
            }
        };*/

        
    }
}
