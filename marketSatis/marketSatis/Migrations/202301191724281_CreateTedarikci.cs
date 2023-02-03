namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTedarikci : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tedarikcis",
                c => new
                    {
                        TedarikciID = c.Int(nullable: false, identity: true),
                        TedarikciAd = c.String(),
                        TedarikciSoyad = c.String(),
                        TedarikciBorc = c.Int(nullable: false),
                        IrsaliyeNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TedarikciID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tedarikcis");
        }
    }
}
