namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieTableNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET Name = 'Hangover' WHERE ID = '1'");
            Sql("UPDATE Movies SET Name = 'DieHard' WHERE ID = '2'");
            Sql("UPDATE Movies SET Name = 'The Terminator' WHERE ID = '3'");
            Sql("UPDATE Movies SET Name = 'Toy Story' WHERE ID = '4'");
            Sql("UPDATE Movies SET Name = 'Titanic' WHERE ID = '5'");
        }
        
        public override void Down()
        {
        }
    }
}
