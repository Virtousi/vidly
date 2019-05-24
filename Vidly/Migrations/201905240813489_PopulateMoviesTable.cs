namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies(ID,DateReleased,DateAdded,Stocks,GenreTypeID) VALUES(1,1990/01/01,2019/05/24,5,1)");
            Sql("INSERT INTO Movies(ID,DateReleased,DateAdded,Stocks,GenreTypeID) VALUES(2,1991/01/01,2019/05/24,4,2)");
            Sql("INSERT INTO Movies(ID,DateReleased,DateAdded,Stocks,GenreTypeID) VALUES(3,1992/01/01,2019/05/24,3,2)");
            Sql("INSERT INTO Movies(ID,DateReleased,DateAdded,Stocks,GenreTypeID) VALUES(4,1993/01/01,2019/05/24,10,3)");
            Sql("INSERT INTO Movies(ID,DateReleased,DateAdded,Stocks,GenreTypeID) VALUES(5,1994/01/01,2019/05/24,7,4)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
