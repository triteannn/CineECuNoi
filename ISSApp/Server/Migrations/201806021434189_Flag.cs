namespace Server.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Flag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CentreDonare", "NeedBlood", c => c.Int(nullable: true, defaultValue: 0));
        }

        public override void Down()
        {
            DropColumn("dbo.CentreDonare", "NeedBlood");
        }
    }
}
