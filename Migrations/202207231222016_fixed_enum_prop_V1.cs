namespace IlacSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixed_enum_prop_V1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Occupation", c => c.String());
            AddColumn("dbo.Users", "Institution_type", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Institution");
            DropColumn("dbo.Users", "Occupations");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Occupations", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Institution", c => c.String());
            DropColumn("dbo.Users", "Institution_type");
            DropColumn("dbo.Users", "Occupation");
        }
    }
}
