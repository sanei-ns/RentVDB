namespace RentVDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class daliMigration1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenreId", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_GenreId", newName: "IX_Genre_Id");
            AddColumn("dbo.MovieFormViewModels", "Genre_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MovieFormViewModels", "Genre_Id");
            AddForeignKey("dbo.MovieFormViewModels", "Genre_Id", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.MovieFormViewModels", "GenreId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovieFormViewModels", "GenreId", c => c.Int(nullable: false));
            DropForeignKey("dbo.MovieFormViewModels", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.MovieFormViewModels", new[] { "Genre_Id" });
            DropColumn("dbo.MovieFormViewModels", "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreId");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreId");
        }
    }
}
