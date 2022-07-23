namespace IlacSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_enum_prop_user : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Occupations", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UserMail", c => c.String(nullable: false));
            DropColumn("dbo.Users", "Occupation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Occupation", c => c.String());
            AlterColumn("dbo.Users", "UserMail", c => c.String());
            DropColumn("dbo.Users", "Occupations");
        }
    }
}
