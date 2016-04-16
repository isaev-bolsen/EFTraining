namespace DataAdapter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrainType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trains", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trains", "Type");
        }
    }
}
