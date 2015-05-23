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
                    Content = "<b>Innehåll</b></br><p>testar lite <font color='red'>html</font></p>",
                    CreationDate = DateTime.Now,
                    Author = new Author { Name = "Sebastian", Email = "sebastian@regiondata.se" },
                    Category = new Category { Name = "Solutions" }
                },
                new Article
                {
                    Title = "List processes in Linux",
                    Content = "<h2>Lista alla processer som körs</h2><p>För att lista alla processer som körs på en linux burk, kör:</p><p><i>ps aux </i></p>",
                    CreationDate = DateTime.Now,
                    Author = new Author { Name = "Pierre", Email = "pierre@regiondata.se" },
                    Category = new Category { Name = "LINUX" }
                });
                
        }
    }
}
