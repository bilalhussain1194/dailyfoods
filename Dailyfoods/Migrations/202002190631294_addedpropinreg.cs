namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpropinreg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "address");
        }
    }
}
