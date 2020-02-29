namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpropincategor : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "categoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "categoryID", c => c.Int(nullable: false));
        }
    }
}
