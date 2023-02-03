namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateGirdi : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Entries");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Entries",
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
            
        }
    }
}
