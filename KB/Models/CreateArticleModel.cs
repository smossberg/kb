using KB.Db;
using KB.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KB.Models
{
    public class CreateArticleModel
    {
        KBDB _db = new KBDB();
        public Article Article { get; set; }
        public List<Category> Categories { get; set; }

        public CreateArticleModel()
        {
            Categories = _db.Categories.ToList();
        }
    }
}
