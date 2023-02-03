namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUrunAdColumnInUruns1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uruns", "UrunAd", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uruns", "UrunAd", c => c.Int(nullable: false));
        }
    }
}
