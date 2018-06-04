namespace Server.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class whatever1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormulareCerere", "Grupa", c => c.String());
            AddColumn("dbo.FormulareCerere", "Rh", c => c.String());
            AlterColumn("dbo.FormulareCerere", "CantTrombocite", c => c.Double());
            AlterColumn("dbo.FormulareCerere", "CantPlasma", c => c.Double());
            AlterColumn("dbo.FormulareCerere", "CantGlobuleRosii", c => c.Double());
        }

        public override void Down()
        {
            AlterColumn("dbo.FormulareCerere", "CantGlobuleRosii", c => c.Double(nullable: false));
            AlterColumn("dbo.FormulareCerere", "CantPlasma", c => c.Double(nullable: false));
            AlterColumn("dbo.FormulareCerere", "CantTrombocite", c => c.Double(nullable: false));
            DropColumn("dbo.FormulareCerere", "Rh");
            DropColumn("dbo.FormulareCerere", "Grupa");
        }
    }
}
