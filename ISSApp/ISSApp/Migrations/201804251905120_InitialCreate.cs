namespace ISSApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        IdA = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.IdA);
            
            CreateTable(
                "dbo.Angajat",
                c => new
                    {
                        IdAC = c.Int(nullable: false),
                        CNP = c.String(),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Dob = c.DateTime(nullable: false),
                        CentruDonare_IdCD = c.Int(),
                        DateContact_IdDC = c.Int(),
                    })
                .PrimaryKey(t => t.IdAC)
                .ForeignKey("dbo.Account", t => t.IdAC)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_IdCD)
                .ForeignKey("dbo.DateContact", t => t.DateContact_IdDC)
                .Index(t => t.IdAC)
                .Index(t => t.CentruDonare_IdCD)
                .Index(t => t.DateContact_IdDC);
            
            CreateTable(
                "dbo.CentruDonare",
                c => new
                    {
                        IdCD = c.Int(nullable: false),
                        Denumire = c.String(),
                    })
                .PrimaryKey(t => t.IdCD)
                .ForeignKey("dbo.Adresa", t => t.IdCD)
                .Index(t => t.IdCD);
            
            CreateTable(
                "dbo.Adresa",
                c => new
                    {
                        IdA = c.Int(nullable: false, identity: true),
                        Strada = c.String(),
                        Numar = c.Int(nullable: false),
                        Oras = c.String(),
                        Judet = c.String(),
                    })
                .PrimaryKey(t => t.IdA);
            
            CreateTable(
                "dbo.Donator",
                c => new
                    {
                        IdD = c.Int(nullable: false),
                        CNP = c.String(),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Dob = c.DateTime(nullable: false),
                        CentruDonare_IdCD = c.Int(),
                        DateContact_IdDC = c.Int(),
                    })
                .PrimaryKey(t => t.IdD)
                .ForeignKey("dbo.Account", t => t.IdD)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_IdCD)
                .ForeignKey("dbo.DateContact", t => t.DateContact_IdDC)
                .Index(t => t.IdD)
                .Index(t => t.CentruDonare_IdCD)
                .Index(t => t.DateContact_IdDC);
            
            CreateTable(
                "dbo.DateContact",
                c => new
                    {
                        IdDC = c.Int(nullable: false),
                        Telefon = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.IdDC)
                .ForeignKey("dbo.Adresa", t => t.IdDC)
                .Index(t => t.IdDC);
            
            CreateTable(
                "dbo.PungaSange",
                c => new
                    {
                        IdPS = c.Int(nullable: false),
                        DataRecoltare = c.DateTime(nullable: false),
                        Grupa = c.String(),
                        Rh = c.String(),
                        Target = c.String(),
                        CentruDonare_IdCD = c.Int(),
                    })
                .PrimaryKey(t => t.IdPS)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_IdCD)
                .ForeignKey("dbo.FormularDonare", t => t.IdPS)
                .Index(t => t.IdPS)
                .Index(t => t.CentruDonare_IdCD);
            
            CreateTable(
                "dbo.FormularDonare",
                c => new
                    {
                        IdFD = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.IdFD);
            
            CreateTable(
                "dbo.Medic",
                c => new
                    {
                        IdM = c.Int(nullable: false),
                        CNP = c.String(),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Dob = c.DateTime(nullable: false),
                        DateContact_IdDC = c.Int(),
                        Spital_IdS = c.Int(),
                    })
                .PrimaryKey(t => t.IdM)
                .ForeignKey("dbo.Account", t => t.IdM)
                .ForeignKey("dbo.DateContact", t => t.DateContact_IdDC)
                .ForeignKey("dbo.Spital", t => t.Spital_IdS)
                .Index(t => t.IdM)
                .Index(t => t.DateContact_IdDC)
                .Index(t => t.Spital_IdS);
            
            CreateTable(
                "dbo.Spital",
                c => new
                    {
                        IdS = c.Int(nullable: false),
                        Denumire = c.String(),
                    })
                .PrimaryKey(t => t.IdS)
                .ForeignKey("dbo.Adresa", t => t.IdS)
                .Index(t => t.IdS);
            
            CreateTable(
                "dbo.FormularCerere",
                c => new
                    {
                        IdFC = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.IdFC);
            
            CreateTable(
                "dbo.GlobuleRosii",
                c => new
                    {
                        IdGR = c.Int(nullable: false, identity: true),
                        DataRecoltare = c.DateTime(nullable: false),
                        Cantitate = c.Single(nullable: false),
                        Target = c.String(),
                        FormularCerere_IdFC = c.Int(),
                    })
                .PrimaryKey(t => t.IdGR)
                .ForeignKey("dbo.FormularCerere", t => t.FormularCerere_IdFC)
                .Index(t => t.FormularCerere_IdFC);
            
            CreateTable(
                "dbo.Plasma",
                c => new
                    {
                        IdP = c.Int(nullable: false, identity: true),
                        DataRecoltare = c.DateTime(nullable: false),
                        Cantitate = c.Single(nullable: false),
                        Target = c.String(),
                        FormularCerere_IdFC = c.Int(),
                    })
                .PrimaryKey(t => t.IdP)
                .ForeignKey("dbo.FormularCerere", t => t.FormularCerere_IdFC)
                .Index(t => t.FormularCerere_IdFC);
            
            CreateTable(
                "dbo.Trombocite",
                c => new
                    {
                        IdT = c.Int(nullable: false, identity: true),
                        DataRecoltare = c.DateTime(nullable: false),
                        Cantitate = c.Single(nullable: false),
                        Target = c.String(),
                        FormularCerere_IdFC = c.Int(),
                    })
                .PrimaryKey(t => t.IdT)
                .ForeignKey("dbo.FormularCerere", t => t.FormularCerere_IdFC)
                .Index(t => t.FormularCerere_IdFC);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trombocite", "FormularCerere_IdFC", "dbo.FormularCerere");
            DropForeignKey("dbo.Plasma", "FormularCerere_IdFC", "dbo.FormularCerere");
            DropForeignKey("dbo.GlobuleRosii", "FormularCerere_IdFC", "dbo.FormularCerere");
            DropForeignKey("dbo.Medic", "Spital_IdS", "dbo.Spital");
            DropForeignKey("dbo.Spital", "IdS", "dbo.Adresa");
            DropForeignKey("dbo.Medic", "DateContact_IdDC", "dbo.DateContact");
            DropForeignKey("dbo.Medic", "IdM", "dbo.Account");
            DropForeignKey("dbo.Angajat", "DateContact_IdDC", "dbo.DateContact");
            DropForeignKey("dbo.PungaSange", "IdPS", "dbo.FormularDonare");
            DropForeignKey("dbo.PungaSange", "CentruDonare_IdCD", "dbo.CentruDonare");
            DropForeignKey("dbo.Donator", "DateContact_IdDC", "dbo.DateContact");
            DropForeignKey("dbo.DateContact", "IdDC", "dbo.Adresa");
            DropForeignKey("dbo.Donator", "CentruDonare_IdCD", "dbo.CentruDonare");
            DropForeignKey("dbo.Donator", "IdD", "dbo.Account");
            DropForeignKey("dbo.Angajat", "CentruDonare_IdCD", "dbo.CentruDonare");
            DropForeignKey("dbo.CentruDonare", "IdCD", "dbo.Adresa");
            DropForeignKey("dbo.Angajat", "IdAC", "dbo.Account");
            DropIndex("dbo.Trombocite", new[] { "FormularCerere_IdFC" });
            DropIndex("dbo.Plasma", new[] { "FormularCerere_IdFC" });
            DropIndex("dbo.GlobuleRosii", new[] { "FormularCerere_IdFC" });
            DropIndex("dbo.Spital", new[] { "IdS" });
            DropIndex("dbo.Medic", new[] { "Spital_IdS" });
            DropIndex("dbo.Medic", new[] { "DateContact_IdDC" });
            DropIndex("dbo.Medic", new[] { "IdM" });
            DropIndex("dbo.PungaSange", new[] { "CentruDonare_IdCD" });
            DropIndex("dbo.PungaSange", new[] { "IdPS" });
            DropIndex("dbo.DateContact", new[] { "IdDC" });
            DropIndex("dbo.Donator", new[] { "DateContact_IdDC" });
            DropIndex("dbo.Donator", new[] { "CentruDonare_IdCD" });
            DropIndex("dbo.Donator", new[] { "IdD" });
            DropIndex("dbo.CentruDonare", new[] { "IdCD" });
            DropIndex("dbo.Angajat", new[] { "DateContact_IdDC" });
            DropIndex("dbo.Angajat", new[] { "CentruDonare_IdCD" });
            DropIndex("dbo.Angajat", new[] { "IdAC" });
            DropTable("dbo.Trombocite");
            DropTable("dbo.Plasma");
            DropTable("dbo.GlobuleRosii");
            DropTable("dbo.FormularCerere");
            DropTable("dbo.Spital");
            DropTable("dbo.Medic");
            DropTable("dbo.FormularDonare");
            DropTable("dbo.PungaSange");
            DropTable("dbo.DateContact");
            DropTable("dbo.Donator");
            DropTable("dbo.Adresa");
            DropTable("dbo.CentruDonare");
            DropTable("dbo.Angajat");
            DropTable("dbo.Account");
        }
    }
}
