namespace RentVDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newcustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MovieMays", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieMays", "Image", c => c.Binary());
        }
    }
}
