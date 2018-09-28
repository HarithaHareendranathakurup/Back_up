namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Room : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomDetails",
                c => new
                    {
                        RId = c.Int(nullable: false, identity: true),
                        RoomName = c.String(),
                        Subject = c.String(),
                        startTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.RId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoomDetails");
        }
    }
}
