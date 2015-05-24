using KB.Db;
using KB.Enteties;
using KB.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
            var model = _db.Articles.Find(id);
            return View(model);
        }

        //
        // POST: /Article/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Article article)
        {
            //if (ModelState.IsValid)
            //{
            //    _db.Entry(article).State = EntityState.Modified;
            //    _db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            //return View(article);
            try
            {
                Article a = _db.Articles.Find(id);
                a.Title = article.Title;
                a.Content = article.Content;
                a.Category = article.Category;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(article);
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
        public ActionResult Delete(int id, Article article)
        {
            try
            {
                _db.Articles.Remove(article);
                _db.SaveChanges();

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
            return View("");
        }

        //
        // POST: /Article/Create

        [HttpPost]
        public ActionResult Create(CreateArticleModel article)
        {
            if(ModelState.IsValid)
            {
                _db.Articles.Add(article.Article);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(article);
        }
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}
