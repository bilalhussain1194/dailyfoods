namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPropInProducts : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "category_id" });
            CreateIndex("dbo.Products", "Category_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "Category_id" });
            CreateIndex("dbo.Products", "category_id");
        }
    }
}
