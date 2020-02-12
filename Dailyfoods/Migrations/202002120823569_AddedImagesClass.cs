namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImagesClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        img_path = c.String(),
                        productid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.productid, cascadeDelete: true)
                .Index(t => t.productid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "productid", "dbo.Products");
            DropIndex("dbo.Images", new[] { "productid" });
            DropTable("dbo.Images");
        }
    }
}
