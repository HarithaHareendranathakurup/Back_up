namespace CampusMinds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Minds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Minds",
                c => new
                    {
                        MID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        ContactId = c.String(),
                        TrackId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MID)
                .ForeignKey("dbo.Tracks", t => t.TrackId, cascadeDelete: true)
                .Index(t => t.TrackId);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        Trackid = c.Int(nullable: false, identity: true),
                        TrackName = c.String(),
                        RoomNo = c.Int(nullable: false),
                        LeadName = c.String(),
                    })
                .PrimaryKey(t => t.Trackid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Minds", "TrackId", "dbo.Tracks");
            DropIndex("dbo.Minds", new[] { "TrackId" });
            DropTable("dbo.Tracks");
            DropTable("dbo.Minds");
        }
    }
}
