namespace marketSatis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEntry : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Entrys", newName: "Entries");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Entries", newName: "Entrys");
        }
    }
}
