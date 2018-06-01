namespace Server.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Pista : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormulareDonare", "Target", c => c.String(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.FormulareDonare", "Target");
        }
    }
}
