namespace NasaHeckathonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhotoModelUpdated : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Images", newName: "Photos");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Photos", newName: "Images");
        }
    }
}
