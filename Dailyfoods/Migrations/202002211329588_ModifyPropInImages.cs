namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPropInImages : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Images", "ProductID", "dbo.Products");
            DropIndex("dbo.Images", new[] { "ProductID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Images", "ProductID");
            AddForeignKey("dbo.Images", "ProductID", "dbo.Products", "id", cascadeDelete: true);
        }
    }
}
