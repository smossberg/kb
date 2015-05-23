using KB.Db;
using KB.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KB.Controllers
{
    public class ArticleController : Controller
    {
        KBDB _db = new KBDB();
        //
        // GET: /Article/

        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("List");
        }

        //
        // GET: /Article/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Article article = (from a in _db.Articles
                            where a.Id == id
                            select a).First();
                article.Title = collection.GetValue("Title").ToString();
                article.Content = collection.GetValue("Content").ToString();
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

        //
        // GET: /Article/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Article/Delete/5

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


        public ActionResult Show(int id)
        {
            var model = _db.Articles.Include("Author").Include("Category").FirstOrDefault(a => a.Id == id);
            return View(model);
        }

        public ActionResult List(string category)
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
        //
        // GET: /Article/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Article/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                KB.Enteties.Article article = new Article
                {
                    Title = collection.GetValue("title").ToString(),
                    Content = collection.GetValue("content").ToString(),
                    CreationDate = DateTime.Parse(collection.GetValue("creationdate").ToString()),
                    Author = _db.Authors.Find(1),
                    Category = _db.Categories.Single(c => c.Name == "Solutions")
                };

                _db.Articles.Add(article);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
