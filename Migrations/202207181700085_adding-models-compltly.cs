namespace IlacSitesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelscompltly : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Indications",
                c => new
                    {
                        indications_id = c.Int(nullable: false, identity: true),
                        indications_details = c.String(),
                    })
                .PrimaryKey(t => t.indications_id);
            
            CreateTable(
                "dbo.MonoklonalAntikors",
                c => new
                    {
                        ma_id = c.Int(nullable: false, identity: true),
                        icd10_code = c.String(),
                        dose = c.String(),
                        defined_daily_dose = c.String(),
                        producer_id = c.Int(nullable: false),
                        indications_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ma_id)
                .ForeignKey("dbo.Indications", t => t.indications_id, cascadeDelete: true)
                .ForeignKey("dbo.Producers", t => t.producer_id, cascadeDelete: true)
                .Index(t => t.producer_id)
                .Index(t => t.indications_id);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        producer_id = c.Int(nullable: false, identity: true),
                        producer_name = c.String(),
                    })
                .PrimaryKey(t => t.producer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonoklonalAntikors", "producer_id", "dbo.Producers");
            DropForeignKey("dbo.MonoklonalAntikors", "indications_id", "dbo.Indications");
            DropIndex("dbo.MonoklonalAntikors", new[] { "indications_id" });
            DropIndex("dbo.MonoklonalAntikors", new[] { "producer_id" });
            DropTable("dbo.Producers");
            DropTable("dbo.MonoklonalAntikors");
            DropTable("dbo.Indications");
        }
    }
}
