namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProductClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        qty = c.Int(nullable: false),
                        description = c.String(),
                        price = c.Int(nullable: false),
                        special_price = c.Int(nullable: false),
                        date_from = c.DateTime(nullable: false),
                        date_to = c.DateTime(nullable: false),
                        created_date = c.DateTime(nullable: false),
                        sku = c.String(),
                        categoryid = c.Int(nullable: false),
                        category_id = c.Byte(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.categories", t => t.category_id)
                .Index(t => t.category_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_id", "dbo.categories");
            DropIndex("dbo.Products", new[] { "category_id" });
            DropTable("dbo.Products");
        }
    }
}
