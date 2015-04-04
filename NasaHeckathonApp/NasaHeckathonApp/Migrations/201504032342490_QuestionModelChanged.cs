namespace NasaHeckathonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestionModelChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "CropName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Questions", "CropName");
        }
    }
}
