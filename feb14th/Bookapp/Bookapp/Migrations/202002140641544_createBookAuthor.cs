namespace Bookapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createBookAuthor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Aid = c.Int(nullable: false, identity: true),
                        Aname = c.String(maxLength: 250),
                        Address = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Aid);
            
            CreateTable(
                "dbo.Details",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Bid = c.Int(nullable: false),
                        Aid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Aid, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Bid, cascadeDelete: true)
                .Index(t => t.Bid)
                .Index(t => t.Aid);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Bid = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 250),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Bid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Details", "Bid", "dbo.Books");
            DropForeignKey("dbo.Details", "Aid", "dbo.Authors");
            DropIndex("dbo.Details", new[] { "Aid" });
            DropIndex("dbo.Details", new[] { "Bid" });
            DropTable("dbo.Books");
            DropTable("dbo.Details");
            DropTable("dbo.Authors");
        }
    }
}
