namespace DataAdapter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable("dbo.Trains", c => new
            {
                ID = c.Guid(nullable: false),
                StationFrom = c.String(),
                Departure = c.DateTime(nullable: false),
                StationTo = c.String(),
                Arrival = c.DateTime(nullable: false),
            }).PrimaryKey(t => t.ID);

        }

        public override void Down()
        {
            DropTable("dbo.Trains");
        }
    }
}
