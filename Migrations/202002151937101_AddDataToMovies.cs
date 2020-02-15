namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hangover', 'Comedy', '20090605', '20180714', 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 'Action', '19880720', '20141127', 3)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 'Action', '19841026', '20151001', 4)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 'Family', '19951122', '20130208', 8)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 'Romance', '19971219', '20150319', 5)");
        }
        
        public override void Down()
        {
        }
    }
}
