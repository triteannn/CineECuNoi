namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlusBoliAnaliza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Analize", "ListaBoliDetectate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Analize", "ListaBoliDetectate");
        }
    }
}
