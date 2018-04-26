namespace ISSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adresa", "IdS", c => c.Int(nullable: false));
            AddColumn("dbo.Adresa", "IdCD", c => c.Int(nullable: false));
            AddColumn("dbo.Adresa", "IdDC", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Adresa", "IdDC");
            DropColumn("dbo.Adresa", "IdCD");
            DropColumn("dbo.Adresa", "IdS");
        }
    }
}
