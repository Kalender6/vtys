namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entrys",
                c => new
                    {
                        EntryID = c.Int(nullable: false, identity: true),
                        EntryIrsaliye = c.Int(nullable: false),
                        EntryFiyat = c.Int(nullable: false),
                        EntryMiktar = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        EntryDate = c.String(),
                        EntryTedarik = c.String(),
                    })
                .PrimaryKey(t => t.EntryID);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        SatisID = c.Int(nullable: false, identity: true),
                        UrunID = c.Int(nullable: false),
                        UrunFiyat = c.Int(nullable: false),
                        UrunMiktar = c.Int(nullable: false),
                        UrunTarih = c.String(),
                        Ver_Pes = c.String(),
                    })
                .PrimaryKey(t => t.SatisID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockID = c.Int(nullable: false, identity: true),
                        UrunID = c.Int(nullable: false),
                        UrunMiktarı = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stocks");
            DropTable("dbo.Sales");
            DropTable("dbo.Entrys");
        }
    }
}
