namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpropincategoryyy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "category_id", c => c.Byte());
            CreateIndex("dbo.Products", "category_id");
            AddForeignKey("dbo.Products", "category_id", "dbo.categories", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_id", "dbo.categories");
            DropIndex("dbo.Products", new[] { "category_id" });
            DropColumn("dbo.Products", "category_id");
        }
    }
}
