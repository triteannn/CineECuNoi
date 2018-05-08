namespace ISSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomeNullIssues : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Donatori", "IdCd", "dbo.CentreDonare");
            DropIndex("dbo.Donatori", new[] { "IdCd" });
            AlterColumn("dbo.Donatori", "IdDc", c => c.Int());
            AlterColumn("dbo.Donatori", "IdCd", c => c.Int());
            CreateIndex("dbo.Donatori", "IdCd");
            AddForeignKey("dbo.Donatori", "IdCd", "dbo.CentreDonare", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donatori", "IdCd", "dbo.CentreDonare");
            DropIndex("dbo.Donatori", new[] { "IdCd" });
            AlterColumn("dbo.Donatori", "IdCd", c => c.Int(nullable: false));
            AlterColumn("dbo.Donatori", "IdDc", c => c.Int(nullable: false));
            CreateIndex("dbo.Donatori", "IdCd");
            AddForeignKey("dbo.Donatori", "IdCd", "dbo.CentreDonare", "Id", cascadeDelete: true);
        }
    }
}
