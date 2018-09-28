namespace BookStore.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cosmetics : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbBookDetails",
                c => new
                    {
                        Book_ID = c.Int(nullable: false, identity: true),
                        Book_Title = c.String(nullable: false),
                        Author = c.String(),
                        Location = c.String(nullable: false),
                        Category = c.String(),
                        Pages = c.String(),
                        Tags = c.String(),
                    })
                .PrimaryKey(t => t.Book_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbBookDetails");
        }
    }
}
