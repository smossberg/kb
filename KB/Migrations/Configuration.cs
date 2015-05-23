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
                    Content = "<h2>Innehåll</h2><p>testar lite <font color='red'>html</font></p>",
                    CreationDate = DateTime.Now,
                    Author = new Author { Name = "Sebastian", Email = "sebastian@regiondata.se" },
                    Category = new Category { Name = "Solutions" }
                },
                new Article
                {
                    Title = "Controller Method Convention",
                    Content = "<h4>Rob Conery at MS suggested some useful RESTful style naming for actions.</h4>"
                                + "<code><span class='pun'>*</span>"+
                                "<span class='pln'></span> " +
                                "<span class='typ'>Index</span>"+
                                "<span class='pln'></span>" +
                                "<span class='pun'>-</span>"+
                                "<span class='pln'> the main </span>"+
                                "<span class='str'>'landing'</span>"+
                                "<span class='pln'> page</span>"+
                                "<span class='pun'>.</span><span class='pln'> </span><span class='typ'>This</span><span class='pln'> </span><span class='kwd'>is</span><span class='pln'> also the </span><span class='kwd'>default</span><span class='pln'> endpoint</span><span class='pun'>.</span><span class='pln'></span><span class='pun'>*</span><span class='pln'> </span><span class='typ'>List</span><span class='pln'> </span><span class='pun'>-</span><span class='pln'> a list of whatever </span><span class='str'>'thing'</span><span class='pln'> you</span><span class='str'>'re showing them - like a list of Products.* Show - a particular item of whatever 'thing' you'</span><span class='pln'>re showing them </span><span class='pun'>(</span><span class='pln'>like a </span><span class='typ'>Product</span><span class='pun'>)</span><span class='pln'></span><span class='pun'>*</span><span class='pln'> </span><span class='typ'>Edit</span><span class='pln'> </span><span class='pun'>-</span><span class='pln'> an edit page </span><span class='kwd'>for</span><span class='pln'> the </span><span class='str'>'thing'</span><span class='pln'></span><span class='pun'>*</span><span class='pln'> </span><span class='typ'>New</span><span class='pln'> </span><span class='pun'>-</span><span class='pln'> a create page </span><span class='kwd'>for</span><span class='pln'> the </span><span class='str'>'thing'</span><span class='pln'></span><span class='pun'>*</span><span class='pln'> </span><span class='typ'>Create</span><span class='pln'> </span><span class='pun'>-</span><span class='pln'> creates a </span><span class='kwd'>new</span><span class='pln'> </span><span class='str'>'thing'</span><span class='pln'> </span><span class='pun'>(</span><span class='kwd'>and</span><span class='pln'> saves it </span><span class='kwd'>if</span><span class='pln'> you</span><span class='str'>'re using a DB)* Update - updates the 'thing'* Delete - deletes the 'thing'</span></code>",
                    CreationDate = DateTime.Now,
                    Author = new Author { Name = "Sebastian", Email = "sebastian@regiondata.se" },
                    Category = new Category { Name = "MVC" }
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
