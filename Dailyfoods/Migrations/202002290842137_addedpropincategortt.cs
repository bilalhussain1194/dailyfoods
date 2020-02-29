namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpropincategortt : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "category_id", "dbo.categories");
            DropIndex("dbo.Products", new[] { "category_id" });
            RenameColumn(table: "dbo.Products", name: "category_id", newName: "categoryid");
            AlterColumn("dbo.Products", "categoryid", c => c.Byte(nullable: false));
            CreateIndex("dbo.Products", "categoryid");
            AddForeignKey("dbo.Products", "categoryid", "dbo.categories", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "categoryid", "dbo.categories");
            DropIndex("dbo.Products", new[] { "categoryid" });
            AlterColumn("dbo.Products", "categoryid", c => c.Byte());
            RenameColumn(table: "dbo.Products", name: "categoryid", newName: "category_id");
            CreateIndex("dbo.Products", "category_id");
            AddForeignKey("dbo.Products", "category_id", "dbo.categories", "id");
        }
    }
}
