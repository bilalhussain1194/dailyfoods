namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.categories", "Product_id", c => c.Int());
            CreateIndex("dbo.categories", "Product_id");
            AddForeignKey("dbo.categories", "Product_id", "dbo.Products", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.categories", "Product_id", "dbo.Products");
            DropIndex("dbo.categories", new[] { "Product_id" });
            DropColumn("dbo.categories", "Product_id");
        }
    }
}
