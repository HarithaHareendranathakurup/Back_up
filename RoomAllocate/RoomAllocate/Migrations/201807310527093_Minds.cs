namespace RoomAllocate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Minds : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllocateRooms",
                c => new
                    {
                        SNO = c.Int(nullable: false, identity: true),
                        MNO = c.Int(nullable: false),
                        RNO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SNO)
                .ForeignKey("dbo.Rooms", t => t.RNO, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.MNO, cascadeDelete: true)
                .Index(t => t.MNO, unique: true)
                .Index(t => t.RNO, unique: true);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RNO = c.Int(nullable: false, identity: true),
                        RID = c.String(nullable: false),
                        BlockName = c.String(nullable: false),
                        FloorName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RNO);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        MNO = c.Int(nullable: false, identity: true),
                        MID = c.String(nullable: false),
                        MindName = c.String(nullable: false),
                        TrackName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MNO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AllocateRooms", "MNO", "dbo.Users");
            DropForeignKey("dbo.AllocateRooms", "RNO", "dbo.Rooms");
            DropIndex("dbo.AllocateRooms", new[] { "RNO" });
            DropIndex("dbo.AllocateRooms", new[] { "MNO" });
            DropTable("dbo.Users");
            DropTable("dbo.Rooms");
            DropTable("dbo.AllocateRooms");
        }
    }
}
