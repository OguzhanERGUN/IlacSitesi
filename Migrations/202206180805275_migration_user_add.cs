namespace IlacSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_user_add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserMail = c.String(),
                        UserName = c.String(),
                        UserPassword = c.String(),
                        EntiryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
