namespace Server.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormulareDonare", "Status", c => c.String(nullable: true, defaultValue: "Received"));
        }

        public override void Down()
        {
            DropColumn("dbo.FormulareDonare", "Status");
        }
    }
}
