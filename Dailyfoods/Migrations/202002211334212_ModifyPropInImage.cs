namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyPropInImage : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Images", "ProductID");
            AddForeignKey("dbo.Images", "ProductID", "dbo.Products", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "ProductID", "dbo.Products");
            DropIndex("dbo.Images", new[] { "ProductID" });
        }
    }
}
