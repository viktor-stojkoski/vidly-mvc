namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenresFixed : DbMigration
    {
        public override void Up()
        {
            // Restart the Identity number
            Sql("DBCC CHECKIDENT ('[Genres]', RESEED, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
