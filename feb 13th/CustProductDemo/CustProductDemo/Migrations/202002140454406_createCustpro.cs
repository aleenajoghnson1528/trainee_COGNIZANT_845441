namespace CustProductDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createCustpro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(nullable: false),
                        Caddress = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Cid = c.Int(nullable: false),
                        Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Cid, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Pid, cascadeDelete: true)
                .Index(t => t.Cid)
                .Index(t => t.Pid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(maxLength: 250),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Pid", "dbo.Products");
            DropForeignKey("dbo.Purchases", "Cid", "dbo.Customers");
            DropIndex("dbo.Purchases", new[] { "Pid" });
            DropIndex("dbo.Purchases", new[] { "Cid" });
            DropTable("dbo.Products");
            DropTable("dbo.Purchases");
            DropTable("dbo.Customers");
        }
    }
}
