namespace ISSApp.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class NewEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Analize",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataRecoltarii = c.DateTime(nullable: false),
                    Eritrocite = c.Double(nullable: false),
                    Hemoglobina = c.Double(nullable: false),
                    Hematocrit = c.Double(nullable: false),
                    VEM = c.Double(nullable: false),
                    HEM = c.Double(nullable: false),
                    CHEM = c.Double(nullable: false),
                    LatimeDistribEritrocit = c.Double(nullable: false),
                    Trombocite = c.Double(nullable: false),
                    VolumMediuTrombocitar = c.Double(nullable: false),
                    Trombocrit = c.Double(nullable: false),
                    LatimeDistribTrombocit = c.Double(nullable: false),
                    Leucocite = c.Double(nullable: false),
                    Granulocite = c.Double(nullable: false),
                    Limfocite = c.Double(nullable: false),
                    MID = c.Double(nullable: false),
                    NumarGranulocite = c.Double(nullable: false),
                    NumarLimfocite = c.Double(nullable: false),
                    NumarMID = c.Double(nullable: false),
                    Glicemie = c.Double(nullable: false),
                    ALT_TGP = c.Double(nullable: false),
                    Colesterol = c.Double(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.FormulareDonare", "DataCreare", c => c.DateTime(nullable: false));
            AddColumn("dbo.FormulareDonare", "ListaBoli", c => c.String());
            AddColumn("dbo.FormulareDonare", "IdAn", c => c.Int(nullable: true));
            CreateIndex("dbo.FormulareDonare", "IdAn");
            AddForeignKey("dbo.FormulareDonare", "IdAn", "dbo.Analize", "Id");
        }

        public override void Down()
        {
            DropForeignKey("dbo.FormulareDonare", "IdAn", "dbo.Analize");
            DropIndex("dbo.FormulareDonare", new[] { "IdAn" });
            DropColumn("dbo.FormulareDonare", "IdAn");
            DropColumn("dbo.FormulareDonare", "ListaBoli");
            DropColumn("dbo.FormulareDonare", "DataCreare");
            DropTable("dbo.Analize");
        }
    }
}
