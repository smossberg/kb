namespace KB.Migrations
{
    using KB.Enteties;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<KB.Db.KBDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(KB.Db.KBDB context)
        {

            context.Articles.AddOrUpdate(a => a.Title,
                new Article
                {
                    Title = "Test Artikeln",
                    Content = "Innehåll",
                    CreationDate = DateTime.Now,
                    Author = new Author { Name = "Sebastian", Email = "sebastian@regiondata.se" },
                    Category = new Category { Name = "Solutions" }
                });
                
        }
    }
}
