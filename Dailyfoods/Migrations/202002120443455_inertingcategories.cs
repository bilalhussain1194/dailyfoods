namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inertingcategories : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.categories");
            AlterColumn("dbo.categories", "id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.categories", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.categories");
            AlterColumn("dbo.categories", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.categories", "id");
        }
    }
}
