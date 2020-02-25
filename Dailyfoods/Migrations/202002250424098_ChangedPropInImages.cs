namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedPropInImages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "filename", c => c.String());
            AddColumn("dbo.Images", "extension", c => c.String());
            DropColumn("dbo.Images", "img_path");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Images", "img_path", c => c.String());
            DropColumn("dbo.Images", "extension");
            DropColumn("dbo.Images", "filename");
        }
    }
}
