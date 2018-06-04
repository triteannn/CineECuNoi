namespace Server.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class whatever2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormulareCerere", "IdCd", c => c.Int(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.FormulareCerere", "IdCd");
        }
    }
}
