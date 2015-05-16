using KB.Enteties;
using KB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KB.Db
{
    public class KBDB : DbContext
    {
        public KBDB() : base("name=DefaultConnection")
        {

        }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}