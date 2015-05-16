namespace KB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        Content = c.String(),
                        Author_id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_id)
                .Index(t => t.Author_id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Articles", new[] { "Author_id" });
            DropForeignKey("dbo.Articles", "Author_id", "dbo.Authors");
            DropTable("dbo.Categories");
            DropTable("dbo.Authors");
            DropTable("dbo.Articles");
        }
    }
}
