namespace IlacSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_new_models : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "UserSurname", c => c.String());
            AddColumn("dbo.Users", "PhoneNumber", c => c.String());
            AddColumn("dbo.Users", "Occupation", c => c.String());
            AddColumn("dbo.Users", "Institution", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Institution");
            DropColumn("dbo.Users", "Occupation");
            DropColumn("dbo.Users", "PhoneNumber");
            DropColumn("dbo.Users", "UserSurname");
        }
    }
}
