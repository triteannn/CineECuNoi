namespace Server.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class whatever : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AngajatiCentru", "IdA", "dbo.Accounts");
            DropForeignKey("dbo.Donatori", "IdA", "dbo.Accounts");
            DropForeignKey("dbo.Medici", "IdA", "dbo.Accounts");
            AddColumn("dbo.Donatori", "Grupa", c => c.String(nullable: true));
            AddColumn("dbo.Donatori", "Rh", c => c.String(nullable: true));
            AddColumn("dbo.FormulareCerere", "Status", c => c.String(nullable: true));
            AddForeignKey("dbo.AngajatiCentru", "IdA", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Donatori", "IdA", "dbo.Accounts", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Medici", "IdA", "dbo.Accounts", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Medici", "IdA", "dbo.Accounts");
            DropForeignKey("dbo.Donatori", "IdA", "dbo.Accounts");
            DropForeignKey("dbo.AngajatiCentru", "IdA", "dbo.Accounts");
            DropColumn("dbo.FormulareCerere", "Status");
            DropColumn("dbo.Donatori", "Rh");
            DropColumn("dbo.Donatori", "Grupa");
            AddForeignKey("dbo.Medici", "IdA", "dbo.Accounts", "Id");
            AddForeignKey("dbo.Donatori", "IdA", "dbo.Accounts", "Id");
            AddForeignKey("dbo.AngajatiCentru", "IdA", "dbo.Accounts", "Id");
        }
    }
}
