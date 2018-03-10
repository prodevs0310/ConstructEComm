namespace ConstructEComm.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addfullnamemobilenumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String(maxLength: 100));
            AddColumn("dbo.AspNetUsers", "MobileNumber", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "MobileNumber");
            DropColumn("dbo.AspNetUsers", "FullName");
        }
    }
}
