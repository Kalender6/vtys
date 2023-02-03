namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUrunAdColumnInUruns : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uruns", "UrunAd", c => c.Int(nullable: false));
            AddColumn("dbo.Uruns", "UrunFiyat", c => c.Int(nullable: false));
            AddColumn("dbo.Uruns", "UrunMiktar", c => c.Int(nullable: false));
            AddColumn("dbo.Uruns", "UrunBarkod", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uruns", "UrunBarkod");
            DropColumn("dbo.Uruns", "UrunMiktar");
            DropColumn("dbo.Uruns", "UrunFiyat");
            DropColumn("dbo.Uruns", "UrunAd");
        }
    }
}
