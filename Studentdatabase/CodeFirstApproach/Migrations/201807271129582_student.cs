namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GradeId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        GradeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Grades", t => t.GradeId, cascadeDelete: true)
                .Index(t => t.GradeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "GradeId", "dbo.Grades");
            DropIndex("dbo.Students", new[] { "GradeId" });
            DropTable("dbo.Students");
            DropTable("dbo.Grades");
        }
    }
}
