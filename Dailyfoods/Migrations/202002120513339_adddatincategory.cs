namespace Dailyfoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddatincategory : DbMigration
    {
        public override void Up()
        {
            Sql("insert into categories values(1,'chifo')");
            Sql("insert into categories values(2,'cater care')");
            Sql("insert into categories values(3,'cooking club')");
            Sql("insert into categories values(4,'omama')");
            Sql("insert into categories values(5,'herbi')");
            Sql("insert into categories values(6,'daily')");
        }
        
        public override void Down()
        {
        }
    }
}
