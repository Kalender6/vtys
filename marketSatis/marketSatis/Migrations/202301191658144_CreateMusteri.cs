namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusteri : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        MusteriBorc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MusteriID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musteris");
        }
    }
}
