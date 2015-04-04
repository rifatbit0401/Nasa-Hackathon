namespace NasaHeckathonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RankModelChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ranks", "Point", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ranks", "Point");
        }
    }
}
