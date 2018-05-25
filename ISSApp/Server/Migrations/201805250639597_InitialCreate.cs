namespace Server.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(),
                    Password = c.String(),
                    IdD = c.Int(),
                    IdM = c.Int(),
                    IdAc = c.Int(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.AngajatiCentru",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    CNP = c.String(),
                    Nume = c.String(),
                    Prenume = c.String(),
                    Dob = c.DateTime(nullable: true),
                    IdCd = c.Int(nullable: true),
                    IdA = c.Int(nullable: true),
                    IdDc = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.IdA)
                .ForeignKey("dbo.CentreDonare", t => t.IdCd, cascadeDelete: true)
                .ForeignKey("dbo.DateContact", t => t.IdDc)
                .Index(t => t.IdCd)
                .Index(t => t.IdA)
                .Index(t => t.IdDc);

            CreateTable(
                "dbo.CentreDonare",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Denumire = c.String(),
                    IdAdr = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adrese", t => t.IdAdr)
                .Index(t => t.IdAdr);

            CreateTable(
                "dbo.Adrese",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Strada = c.String(),
                    Numar = c.Int(nullable: true),
                    Oras = c.String(),
                    Judet = c.String(),
                    Longitude = c.Double(nullable: true),
                    Latitude = c.Double(nullable: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.DateContact",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Telefon = c.String(),
                    Email = c.String(),
                    IdAdr = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adrese", t => t.IdAdr)
                .Index(t => t.IdAdr);

            CreateTable(
                "dbo.Donatori",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    CNP = c.String(),
                    Nume = c.String(),
                    Prenume = c.String(),
                    Dob = c.DateTime(nullable: true),
                    IdCd = c.Int(),
                    IdA = c.Int(nullable: true),
                    IdDc = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.IdA)
                .ForeignKey("dbo.CentreDonare", t => t.IdCd)
                .ForeignKey("dbo.DateContact", t => t.IdDc)
                .Index(t => t.IdCd)
                .Index(t => t.IdA)
                .Index(t => t.IdDc);

            CreateTable(
                "dbo.FormulareDonare",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataCreare = c.DateTime(nullable: true),
                    ListaBoli = c.String(),
                    IdAn = c.Int(nullable: true),
                    IdD = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Analize", t => t.IdAn)
                .ForeignKey("dbo.Donatori", t => t.IdD)
                .Index(t => t.IdAn)
                .Index(t => t.IdD);

            CreateTable(
                "dbo.Analize",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataRecoltarii = c.DateTime(nullable: true),
                    Eritrocite = c.Double(nullable: true),
                    Hemoglobina = c.Double(nullable: true),
                    Hematocrit = c.Double(nullable: true),
                    VEM = c.Double(nullable: true),
                    HEM = c.Double(nullable: true),
                    CHEM = c.Double(nullable: true),
                    LatimeDistribEritrocit = c.Double(nullable: true),
                    Trombocite = c.Double(nullable: true),
                    VolumMediuTrombocitar = c.Double(nullable: true),
                    Trombocrit = c.Double(nullable: true),
                    LatimeDistribTrombocit = c.Double(nullable: true),
                    Leucocite = c.Double(nullable: true),
                    Granulocite = c.Double(nullable: true),
                    Limfocite = c.Double(nullable: true),
                    MID = c.Double(nullable: true),
                    NumarGranulocite = c.Double(nullable: true),
                    NumarLimfocite = c.Double(nullable: true),
                    NumarMID = c.Double(nullable: true),
                    Glicemie = c.Double(nullable: true),
                    ALT_TGP = c.Double(nullable: true),
                    Colesterol = c.Double(nullable: true),
                    ListaBoliDetectate = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PungiSange",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataRecoltare = c.DateTime(nullable: true),
                    Grupa = c.String(),
                    Rh = c.String(),
                    Target = c.String(),
                    IdCd = c.Int(nullable: true),
                    IdFd = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentreDonare", t => t.IdCd, cascadeDelete: true)
                .ForeignKey("dbo.FormulareDonare", t => t.IdFd)
                .Index(t => t.IdCd)
                .Index(t => t.IdFd);

            CreateTable(
                "dbo.Medici",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    CNP = c.String(),
                    Nume = c.String(),
                    Prenume = c.String(),
                    Dob = c.DateTime(nullable: true),
                    IdS = c.Int(nullable: true),
                    IdA = c.Int(nullable: true),
                    IdDc = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.IdA)
                .ForeignKey("dbo.DateContact", t => t.IdDc)
                .ForeignKey("dbo.Spitale", t => t.IdS, cascadeDelete: true)
                .Index(t => t.IdS)
                .Index(t => t.IdA)
                .Index(t => t.IdDc);

            CreateTable(
                "dbo.FormulareCerere",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Target = c.String(),
                    CantTrombocite = c.Double(nullable: true),
                    CantPlasma = c.Double(nullable: true),
                    CantGlobuleRosii = c.Double(nullable: true),
                    IdM = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medici", t => t.IdM)
                .Index(t => t.IdM);

            CreateTable(
                "dbo.Spitale",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Denumire = c.String(),
                    IdAdr = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adrese", t => t.IdAdr)
                .Index(t => t.IdAdr);

            CreateTable(
                "dbo.PSGlobuleRosii",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Cantitate = c.Single(nullable: true),
                    Target = c.String(),
                    DataExpirare = c.DateTime(nullable: true),
                    Grupa = c.String(),
                    Rh = c.String(),
                    IdCD = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentreDonare", t => t.IdCD, cascadeDelete: true)
                .Index(t => t.IdCD);

            CreateTable(
                "dbo.PSPlasme",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Cantitate = c.Single(nullable: true),
                    Target = c.String(),
                    DataExpirare = c.DateTime(nullable: true),
                    Grupa = c.String(),
                    Rh = c.String(),
                    IdCD = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentreDonare", t => t.IdCD, cascadeDelete: true)
                .Index(t => t.IdCD);

            CreateTable(
                "dbo.PSTrombocite",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Cantitate = c.Single(nullable: true),
                    Target = c.String(),
                    DataExpirare = c.DateTime(nullable: true),
                    Grupa = c.String(),
                    Rh = c.String(),
                    IdCD = c.Int(nullable: true),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentreDonare", t => t.IdCD, cascadeDelete: true)
                .Index(t => t.IdCD);

        }

        public override void Down()
        {
            DropForeignKey("dbo.AngajatiCentru", "IdDc", "dbo.DateContact");
            DropForeignKey("dbo.AngajatiCentru", "IdCd", "dbo.CentreDonare");
            DropForeignKey("dbo.PSTrombocite", "IdCD", "dbo.CentreDonare");
            DropForeignKey("dbo.PSPlasme", "IdCD", "dbo.CentreDonare");
            DropForeignKey("dbo.PSGlobuleRosii", "IdCD", "dbo.CentreDonare");
            DropForeignKey("dbo.CentreDonare", "IdAdr", "dbo.Adrese");
            DropForeignKey("dbo.Medici", "IdS", "dbo.Spitale");
            DropForeignKey("dbo.Spitale", "IdAdr", "dbo.Adrese");
            DropForeignKey("dbo.FormulareCerere", "IdM", "dbo.Medici");
            DropForeignKey("dbo.Medici", "IdDc", "dbo.DateContact");
            DropForeignKey("dbo.Medici", "IdA", "dbo.Accounts");
            DropForeignKey("dbo.PungiSange", "IdFd", "dbo.FormulareDonare");
            DropForeignKey("dbo.PungiSange", "IdCd", "dbo.CentreDonare");
            DropForeignKey("dbo.FormulareDonare", "IdD", "dbo.Donatori");
            DropForeignKey("dbo.FormulareDonare", "IdAn", "dbo.Analize");
            DropForeignKey("dbo.Donatori", "IdDc", "dbo.DateContact");
            DropForeignKey("dbo.Donatori", "IdCd", "dbo.CentreDonare");
            DropForeignKey("dbo.Donatori", "IdA", "dbo.Accounts");
            DropForeignKey("dbo.DateContact", "IdAdr", "dbo.Adrese");
            DropForeignKey("dbo.AngajatiCentru", "IdA", "dbo.Accounts");
            DropIndex("dbo.PSTrombocite", new[] { "IdCD" });
            DropIndex("dbo.PSPlasme", new[] { "IdCD" });
            DropIndex("dbo.PSGlobuleRosii", new[] { "IdCD" });
            DropIndex("dbo.Spitale", new[] { "IdAdr" });
            DropIndex("dbo.FormulareCerere", new[] { "IdM" });
            DropIndex("dbo.Medici", new[] { "IdDc" });
            DropIndex("dbo.Medici", new[] { "IdA" });
            DropIndex("dbo.Medici", new[] { "IdS" });
            DropIndex("dbo.PungiSange", new[] { "IdFd" });
            DropIndex("dbo.PungiSange", new[] { "IdCd" });
            DropIndex("dbo.FormulareDonare", new[] { "IdD" });
            DropIndex("dbo.FormulareDonare", new[] { "IdAn" });
            DropIndex("dbo.Donatori", new[] { "IdDc" });
            DropIndex("dbo.Donatori", new[] { "IdA" });
            DropIndex("dbo.Donatori", new[] { "IdCd" });
            DropIndex("dbo.DateContact", new[] { "IdAdr" });
            DropIndex("dbo.CentreDonare", new[] { "IdAdr" });
            DropIndex("dbo.AngajatiCentru", new[] { "IdDc" });
            DropIndex("dbo.AngajatiCentru", new[] { "IdA" });
            DropIndex("dbo.AngajatiCentru", new[] { "IdCd" });
            DropTable("dbo.PSTrombocite");
            DropTable("dbo.PSPlasme");
            DropTable("dbo.PSGlobuleRosii");
            DropTable("dbo.Spitale");
            DropTable("dbo.FormulareCerere");
            DropTable("dbo.Medici");
            DropTable("dbo.PungiSange");
            DropTable("dbo.Analize");
            DropTable("dbo.FormulareDonare");
            DropTable("dbo.Donatori");
            DropTable("dbo.DateContact");
            DropTable("dbo.Adrese");
            DropTable("dbo.CentreDonare");
            DropTable("dbo.AngajatiCentru");
            DropTable("dbo.Accounts");
        }
    }
}
