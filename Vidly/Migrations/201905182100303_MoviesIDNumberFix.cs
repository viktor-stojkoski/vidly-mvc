namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoviesIDNumberFix : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT ('[Movies]', RESEED, 5)");
        }
        
        public override void Down()
        {
        }
    }
}
