namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateReleased = c.DateTime(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        Stocks = c.Int(nullable: false),
                        GenreTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.GenreTypes", t => t.GenreTypeID, cascadeDelete: true)
                .Index(t => t.GenreTypeID);
            
            CreateTable(
                "dbo.GenreTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreTypeID", "dbo.GenreTypes");
            DropIndex("dbo.Movies", new[] { "GenreTypeID" });
            DropTable("dbo.GenreTypes");
            DropTable("dbo.Movies");
        }
    }
}
