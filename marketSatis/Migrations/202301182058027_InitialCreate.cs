namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Saticis",
                c => new
                    {
                        SaticiID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.SaticiID);
            
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.UrunID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
            DropTable("dbo.Saticis");
        }
    }
}
