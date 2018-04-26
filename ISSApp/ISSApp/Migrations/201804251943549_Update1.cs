namespace ISSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Account", "IdD", c => c.Int(nullable: false));
            AddColumn("dbo.Account", "IdM", c => c.Int(nullable: false));
            AddColumn("dbo.Account", "IdAC", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Account", "IdAC");
            DropColumn("dbo.Account", "IdM");
            DropColumn("dbo.Account", "IdD");
        }
    }
}
