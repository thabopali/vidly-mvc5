namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesWithGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 1, '2009/11/06', '2016/05/04',5)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 2, '2009/11/06', '2016/05/04',2)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 2, '2009/11/06', '2016/05/04',15)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 3, '2009/11/06', '2016/05/04',25)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, '2009/11/06', '2016/05/04',3)");
        }
        
        public override void Down()
        {
        }
    }
}
