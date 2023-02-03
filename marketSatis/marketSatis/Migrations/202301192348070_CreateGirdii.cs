namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGirdii : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Girdiis",
                c => new
                    {
                        GirdiiID = c.Int(nullable: false, identity: true),
                        UrunID = c.Int(),
                        GirdiiIrsaliye = c.Int(),
                        GirdiiFiyat = c.Int(),
                        GirdiiMiktar = c.Int(),
                        GirdiiTarih = c.String(),
                        GirdiiTedarik = c.String(),
                    })
                .PrimaryKey(t => t.GirdiiID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Girdiis");
        }
    }
}
