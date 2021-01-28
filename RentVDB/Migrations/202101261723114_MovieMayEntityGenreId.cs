namespace RentVDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieMayEntityGenreId : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieMays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieMays", "GenreId", "dbo.Genres");
            DropIndex("dbo.MovieMays", new[] { "GenreId" });
            DropTable("dbo.MovieMays");
        }
    }
}
