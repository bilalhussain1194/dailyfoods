namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "dateofbirth", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AspNetUsers", "phonenumber", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "phonenumber", c => c.String());
            DropColumn("dbo.AspNetUsers", "dateofbirth");
        }
    }
}
