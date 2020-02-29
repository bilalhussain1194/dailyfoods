namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class propinproducts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_id", "dbo.categories");
            DropIndex("dbo.Products", new[] { "Category_id" });
            DropColumn("dbo.Products", "Category_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category_id", c => c.Byte());
            CreateIndex("dbo.Products", "Category_id");
            AddForeignKey("dbo.Products", "Category_id", "dbo.categories", "id");
        }
    }
}
