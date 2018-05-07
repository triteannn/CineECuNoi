namespace ISSApp.Migrations
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
                    Dob = c.DateTime(nullable: false),
                    IdA = c.Int(nullable: false),
                    IdCd = c.Int(nullable: false),
                    IdDc = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentreDonare", t => t.IdA, cascadeDelete: true)
                .ForeignKey("dbo.DateContact", t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.IdA);

            CreateTable(
                "dbo.CentreDonare",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Denumire = c.String(),
                    IdAdr = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adrese", t => t.Id)
                .Index(t => t.Id);

            CreateTable(
                "dbo.Adrese",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Strada = c.String(),
                    Numar = c.Int(nullable: false),
                    Oras = c.String(),
                    Judet = c.String(),
                    IdS = c.Int(),
                    IdCd = c.Int(),
                    IdDc = c.Int(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.DateContact",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Telefon = c.String(),
                    Email = c.String(),
                    IdAdr = c.Int(nullable: false),
                    IdD = c.Int(),
                    IdM = c.Int(),
                    IdAc = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adrese", t => t.Id)
                .Index(t => t.Id);

            CreateTable(
                "dbo.Donatori",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    CNP = c.String(),
                    Nume = c.String(),
                    Prenume = c.String(),
                    Dob = c.DateTime(nullable: false),
                    IdDc = c.Int(nullable: false),
                    IdA = c.Int(nullable: false),
                    IdCd = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentreDonare", t => t.IdCd, cascadeDelete: true)
                .ForeignKey("dbo.DateContact", t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.IdCd);

            CreateTable(
                "dbo.Medici",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    CNP = c.String(),
                    Nume = c.String(),
                    Prenume = c.String(),
                    Dob = c.DateTime(nullable: false),
                    IdDc = c.Int(nullable: false),
                    IdA = c.Int(nullable: false),
                    IdS = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Spitale", t => t.IdS, cascadeDelete: true)
                .ForeignKey("dbo.DateContact", t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.IdS);

            CreateTable(
                "dbo.Spitale",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    Denumire = c.String(),
                    IdAdr = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adrese", t => t.Id)
                .Index(t => t.Id);

            CreateTable(
                "dbo.PungiSange",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataRecoltare = c.DateTime(nullable: false),
                    Grupa = c.String(),
                    Rh = c.String(),
                    Target = c.String(),
                    IdCd = c.Int(nullable: false),
                    IdFd = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentreDonare", t => t.IdCd, cascadeDelete: true)
                .ForeignKey("dbo.FormulareDonare", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.IdCd);

            CreateTable(
                "dbo.FormulareDonare",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    IdPs = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.FormulareCerere",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.PSGlobuleRosii",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataRecoltare = c.DateTime(nullable: false),
                    Cantitate = c.Single(nullable: false),
                    Target = c.String(),
                    IdFc = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormulareCerere", t => t.IdFc)
                .Index(t => t.IdFc);

            CreateTable(
                "dbo.PSPlasme",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataRecoltare = c.DateTime(nullable: false),
                    Cantitate = c.Single(nullable: false),
                    Target = c.String(),
                    IdFc = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormulareCerere", t => t.IdFc)
                .Index(t => t.IdFc);

            CreateTable(
                "dbo.PSTrombocite",
                c => new {
                    Id = c.Int(nullable: false, identity: true),
                    DataRecoltare = c.DateTime(nullable: false),
                    Cantitate = c.Single(nullable: false),
                    Target = c.String(),
                    IdFc = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormulareCerere", t => t.IdFc)
                .Index(t => t.IdFc);

        }

        public override void Down()
        {
            DropForeignKey("dbo.PSTrombocite", "IdFc", "dbo.FormulareCerere");
            DropForeignKey("dbo.PSPlasme", "IdFc", "dbo.FormulareCerere");
            DropForeignKey("dbo.PSGlobuleRosii", "IdFc", "dbo.FormulareCerere");
            DropForeignKey("dbo.Medici", "Id", "dbo.Accounts");
            DropForeignKey("dbo.Donatori", "Id", "dbo.Accounts");
            DropForeignKey("dbo.AngajatiCentru", "Id", "dbo.Accounts");
            DropForeignKey("dbo.AngajatiCentru", "Id", "dbo.DateContact");
            DropForeignKey("dbo.AngajatiCentru", "IdA", "dbo.CentreDonare");
            DropForeignKey("dbo.PungiSange", "Id", "dbo.FormulareDonare");
            DropForeignKey("dbo.PungiSange", "IdCd", "dbo.CentreDonare");
            DropForeignKey("dbo.Spitale", "Id", "dbo.Adrese");
            DropForeignKey("dbo.DateContact", "Id", "dbo.Adrese");
            DropForeignKey("dbo.Medici", "Id", "dbo.DateContact");
            DropForeignKey("dbo.Medici", "IdS", "dbo.Spitale");
            DropForeignKey("dbo.Donatori", "Id", "dbo.DateContact");
            DropForeignKey("dbo.Donatori", "IdCd", "dbo.CentreDonare");
            DropForeignKey("dbo.CentreDonare", "Id", "dbo.Adrese");
            DropIndex("dbo.PSTrombocite", new[] { "IdFc" });
            DropIndex("dbo.PSPlasme", new[] { "IdFc" });
            DropIndex("dbo.PSGlobuleRosii", new[] { "IdFc" });
            DropIndex("dbo.PungiSange", new[] { "IdCd" });
            DropIndex("dbo.PungiSange", new[] { "Id" });
            DropIndex("dbo.Spitale", new[] { "Id" });
            DropIndex("dbo.Medici", new[] { "IdS" });
            DropIndex("dbo.Medici", new[] { "Id" });
            DropIndex("dbo.Donatori", new[] { "IdCd" });
            DropIndex("dbo.Donatori", new[] { "Id" });
            DropIndex("dbo.DateContact", new[] { "Id" });
            DropIndex("dbo.CentreDonare", new[] { "Id" });
            DropIndex("dbo.AngajatiCentru", new[] { "IdA" });
            DropIndex("dbo.AngajatiCentru", new[] { "Id" });
            DropTable("dbo.PSTrombocite");
            DropTable("dbo.PSPlasme");
            DropTable("dbo.PSGlobuleRosii");
            DropTable("dbo.FormulareCerere");
            DropTable("dbo.FormulareDonare");
            DropTable("dbo.PungiSange");
            DropTable("dbo.Spitale");
            DropTable("dbo.Medici");
            DropTable("dbo.Donatori");
            DropTable("dbo.DateContact");
            DropTable("dbo.Adrese");
            DropTable("dbo.CentreDonare");
            DropTable("dbo.AngajatiCentru");
            DropTable("dbo.Accounts");
        }
    }
}
