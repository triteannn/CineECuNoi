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
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
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
                        CNP = c.String(nullable: false, maxLength: 128),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Dob = c.DateTime(nullable: false),
                        CentruDonare_IdCD1 = c.Int(),
                        DateContact_IdDC = c.Int(),
                    })
                .PrimaryKey(t => t.CNP)
                .ForeignKey("dbo.Account", t => t.CNP)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_IdCD1)
                .ForeignKey("dbo.DateContact", t => t.DateContact_IdDC)
                .Index(t => t.CNP)
                .Index(t => t.CentruDonare_IdCD1)
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
            
            CreateTable(
                "dbo.Angajat",
                c => new
                    {
                        CNP = c.String(nullable: false, maxLength: 128),
                        CentruDonare_IdCD = c.Int(),
                    })
                .PrimaryKey(t => t.CNP)
                .ForeignKey("dbo.Donator", t => t.CNP)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_IdCD)
                .Index(t => t.CNP)
                .Index(t => t.CentruDonare_IdCD);
            
            CreateTable(
                "dbo.Medic",
                c => new
                    {
                        CNP = c.String(nullable: false, maxLength: 128),
                        Spital_IdS = c.Int(),
                    })
                .PrimaryKey(t => t.CNP)
                .ForeignKey("dbo.Donator", t => t.CNP)
                .ForeignKey("dbo.Spital", t => t.Spital_IdS)
                .Index(t => t.CNP)
                .Index(t => t.Spital_IdS);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medic", "Spital_IdS", "dbo.Spital");
            DropForeignKey("dbo.Medic", "CNP", "dbo.Donator");
            DropForeignKey("dbo.Angajat", "CentruDonare_IdCD", "dbo.CentruDonare");
            DropForeignKey("dbo.Angajat", "CNP", "dbo.Donator");
            DropForeignKey("dbo.Trombocite", "FormularCerere_IdFC", "dbo.FormularCerere");
            DropForeignKey("dbo.Plasma", "FormularCerere_IdFC", "dbo.FormularCerere");
            DropForeignKey("dbo.GlobuleRosii", "FormularCerere_IdFC", "dbo.FormularCerere");
            DropForeignKey("dbo.PungaSange", "IdPS", "dbo.FormularDonare");
            DropForeignKey("dbo.PungaSange", "CentruDonare_IdCD", "dbo.CentruDonare");
            DropForeignKey("dbo.Spital", "IdS", "dbo.Adresa");
            DropForeignKey("dbo.Donator", "DateContact_IdDC", "dbo.DateContact");
            DropForeignKey("dbo.DateContact", "IdDC", "dbo.Adresa");
            DropForeignKey("dbo.Donator", "CentruDonare_IdCD1", "dbo.CentruDonare");
            DropForeignKey("dbo.Donator", "CNP", "dbo.Account");
            DropForeignKey("dbo.CentruDonare", "IdCD", "dbo.Adresa");
            DropIndex("dbo.Medic", new[] { "Spital_IdS" });
            DropIndex("dbo.Medic", new[] { "CNP" });
            DropIndex("dbo.Angajat", new[] { "CentruDonare_IdCD" });
            DropIndex("dbo.Angajat", new[] { "CNP" });
            DropIndex("dbo.Trombocite", new[] { "FormularCerere_IdFC" });
            DropIndex("dbo.Plasma", new[] { "FormularCerere_IdFC" });
            DropIndex("dbo.GlobuleRosii", new[] { "FormularCerere_IdFC" });
            DropIndex("dbo.PungaSange", new[] { "CentruDonare_IdCD" });
            DropIndex("dbo.PungaSange", new[] { "IdPS" });
            DropIndex("dbo.Spital", new[] { "IdS" });
            DropIndex("dbo.DateContact", new[] { "IdDC" });
            DropIndex("dbo.CentruDonare", new[] { "IdCD" });
            DropIndex("dbo.Donator", new[] { "DateContact_IdDC" });
            DropIndex("dbo.Donator", new[] { "CentruDonare_IdCD1" });
            DropIndex("dbo.Donator", new[] { "CNP" });
            DropTable("dbo.Medic");
            DropTable("dbo.Angajat");
            DropTable("dbo.Trombocite");
            DropTable("dbo.Plasma");
            DropTable("dbo.GlobuleRosii");
            DropTable("dbo.FormularCerere");
            DropTable("dbo.FormularDonare");
            DropTable("dbo.PungaSange");
            DropTable("dbo.Spital");
            DropTable("dbo.DateContact");
            DropTable("dbo.CentruDonare");
            DropTable("dbo.Donator");
            DropTable("dbo.Adresa");
            DropTable("dbo.Account");
        }
    }
}
