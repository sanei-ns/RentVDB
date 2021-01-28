namespace RentVDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMovieMay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieMays", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieMays", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovieMays", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.MovieMays", "NumberAvailable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieMays", "NumberAvailable");
            DropColumn("dbo.MovieMays", "NumberInStock");
            DropColumn("dbo.MovieMays", "ReleaseDate");
            DropColumn("dbo.MovieMays", "DateAdded");
        }
    }
}
