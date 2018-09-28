namespace RoomAllocate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rooms : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AllocateRooms", new[] { "RNO" });
            CreateIndex("dbo.AllocateRooms", "RNO");
        }
        
        public override void Down()
        {
            DropIndex("dbo.AllocateRooms", new[] { "RNO" });
            CreateIndex("dbo.AllocateRooms", "RNO", unique: true);
        }
    }
}
