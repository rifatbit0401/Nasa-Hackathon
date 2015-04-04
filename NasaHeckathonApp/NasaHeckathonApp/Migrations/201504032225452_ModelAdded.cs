namespace NasaHeckathonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Description = c.String(),
                        PestName = c.String(),
                        PestDescription = c.String(),
                        PesticideName = c.String(),
                        PesticideDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Path = c.String(),
                        UserId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        AnswerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CurrentLatitude = c.Double(nullable: false),
                        CurrentLongitute = c.Double(nullable: false),
                        PestName = c.String(),
                        PestStartDate = c.DateTime(nullable: false),
                        CurrentDate = c.DateTime(nullable: false),
                        HarvestArea = c.Double(nullable: false),
                        CulivationStartDate = c.DateTime(nullable: false),
                        CultivationFinishDate = c.DateTime(nullable: false),
                        AffectedArea = c.Double(nullable: false),
                        PesticideName = c.String(),
                        PesticideDescription = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ranks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnswerId = c.Int(nullable: false),
                        QuestionId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "ImageId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String());
            DropColumn("dbo.Users", "Point");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Point", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.Users", "ImageId");
            DropTable("dbo.Ranks");
            DropTable("dbo.Questions");
            DropTable("dbo.Images");
            DropTable("dbo.Answers");
        }
    }
}
