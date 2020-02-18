namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationaddedpropinregistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "displayusername", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "displayusername");
        }
    }
}
