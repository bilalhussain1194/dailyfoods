namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPropInImages1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Images");
            DropColumn("dbo.Images", "id");
            AddColumn("dbo.Images", "id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Images", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Images");
            DropColumn("dbo.Images", "id");
            AddColumn("dbo.Images", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Images", "id");
        }
    }
}
