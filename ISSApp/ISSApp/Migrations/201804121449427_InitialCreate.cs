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
                        Strada = c.String(nullable: false, maxLength: 128),
                        Numar = c.Int(nullable: false),
                        Oras = c.String(nullable: false, maxLength: 128),
                        Judet = c.String(),
                    })
                .PrimaryKey(t => new { t.Strada, t.Numar, t.Oras });
            
            CreateTable(
                "dbo.Donator",
                c => new
                    {
                        CNP = c.String(nullable: false, maxLength: 128),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Dob = c.DateTime(nullable: false),
                        Account_Username = c.String(maxLength: 128),
                        CentruDonare_Id1 = c.Int(),
                        DateContact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.CNP)
                .ForeignKey("dbo.Account", t => t.Account_Username)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_Id1)
                .ForeignKey("dbo.DateContact", t => t.DateContact_Id)
                .Index(t => t.Account_Username)
                .Index(t => t.CentruDonare_Id1)
                .Index(t => t.DateContact_Id);
            
            CreateTable(
                "dbo.CentruDonare",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Denumire = c.String(),
                        Adresa_Strada = c.String(maxLength: 128),
                        Adresa_Numar = c.Int(),
                        Adresa_Oras = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresa", t => new { t.Adresa_Strada, t.Adresa_Numar, t.Adresa_Oras })
                .Index(t => new { t.Adresa_Strada, t.Adresa_Numar, t.Adresa_Oras });
            
            CreateTable(
                "dbo.DateContact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Telefon = c.String(),
                        Email = c.String(),
                        Adresa_Strada = c.String(maxLength: 128),
                        Adresa_Numar = c.Int(),
                        Adresa_Oras = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresa", t => new { t.Adresa_Strada, t.Adresa_Numar, t.Adresa_Oras })
                .Index(t => new { t.Adresa_Strada, t.Adresa_Numar, t.Adresa_Oras });
            
            CreateTable(
                "dbo.Spital",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Denumire = c.String(),
                        Adresa_Strada = c.String(maxLength: 128),
                        Adresa_Numar = c.Int(),
                        Adresa_Oras = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adresa", t => new { t.Adresa_Strada, t.Adresa_Numar, t.Adresa_Oras })
                .Index(t => new { t.Adresa_Strada, t.Adresa_Numar, t.Adresa_Oras });
            
            CreateTable(
                "dbo.PungaSange",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DataRecoltare = c.DateTime(nullable: false),
                        Grupa = c.String(),
                        Rh = c.String(),
                        Target = c.String(),
                        CentruDonare_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_Id)
                .ForeignKey("dbo.FormularDonare", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.CentruDonare_Id);
            
            CreateTable(
                "dbo.FormularDonare",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FormularCerere",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GlobuleRosii",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataRecoltare = c.DateTime(nullable: false),
                        Cantitate = c.Single(nullable: false),
                        Target = c.String(),
                        FormularCerere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormularCerere", t => t.FormularCerere_Id)
                .Index(t => t.FormularCerere_Id);
            
            CreateTable(
                "dbo.Plasma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataRecoltare = c.DateTime(nullable: false),
                        Cantitate = c.Single(nullable: false),
                        Target = c.String(),
                        FormularCerere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormularCerere", t => t.FormularCerere_Id)
                .Index(t => t.FormularCerere_Id);
            
            CreateTable(
                "dbo.Trombocite",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataRecoltare = c.DateTime(nullable: false),
                        Cantitate = c.Single(nullable: false),
                        Target = c.String(),
                        FormularCerere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FormularCerere", t => t.FormularCerere_Id)
                .Index(t => t.FormularCerere_Id);
            
            CreateTable(
                "dbo.Angajat",
                c => new
                    {
                        CNP = c.String(nullable: false, maxLength: 128),
                        CentruDonare_Id = c.Int(),
                    })
                .PrimaryKey(t => t.CNP)
                .ForeignKey("dbo.Donator", t => t.CNP)
                .ForeignKey("dbo.CentruDonare", t => t.CentruDonare_Id)
                .Index(t => t.CNP)
                .Index(t => t.CentruDonare_Id);
            
            CreateTable(
                "dbo.Medic",
                c => new
                    {
                        CNP = c.String(nullable: false, maxLength: 128),
                        Spital_Id = c.Int(),
                    })
                .PrimaryKey(t => t.CNP)
                .ForeignKey("dbo.Donator", t => t.CNP)
                .ForeignKey("dbo.Spital", t => t.Spital_Id)
                .Index(t => t.CNP)
                .Index(t => t.Spital_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medic", "Spital_Id", "dbo.Spital");
            DropForeignKey("dbo.Medic", "CNP", "dbo.Donator");
            DropForeignKey("dbo.Angajat", "CentruDonare_Id", "dbo.CentruDonare");
            DropForeignKey("dbo.Angajat", "CNP", "dbo.Donator");
            DropForeignKey("dbo.Trombocite", "FormularCerere_Id", "dbo.FormularCerere");
            DropForeignKey("dbo.Plasma", "FormularCerere_Id", "dbo.FormularCerere");
            DropForeignKey("dbo.GlobuleRosii", "FormularCerere_Id", "dbo.FormularCerere");
            DropForeignKey("dbo.PungaSange", "Id", "dbo.FormularDonare");
            DropForeignKey("dbo.PungaSange", "CentruDonare_Id", "dbo.CentruDonare");
            DropForeignKey("dbo.Spital", new[] { "Adresa_Strada", "Adresa_Numar", "Adresa_Oras" }, "dbo.Adresa");
            DropForeignKey("dbo.Donator", "DateContact_Id", "dbo.DateContact");
            DropForeignKey("dbo.DateContact", new[] { "Adresa_Strada", "Adresa_Numar", "Adresa_Oras" }, "dbo.Adresa");
            DropForeignKey("dbo.Donator", "CentruDonare_Id1", "dbo.CentruDonare");
            DropForeignKey("dbo.Donator", "Account_Username", "dbo.Account");
            DropForeignKey("dbo.CentruDonare", new[] { "Adresa_Strada", "Adresa_Numar", "Adresa_Oras" }, "dbo.Adresa");
            DropIndex("dbo.Medic", new[] { "Spital_Id" });
            DropIndex("dbo.Medic", new[] { "CNP" });
            DropIndex("dbo.Angajat", new[] { "CentruDonare_Id" });
            DropIndex("dbo.Angajat", new[] { "CNP" });
            DropIndex("dbo.Trombocite", new[] { "FormularCerere_Id" });
            DropIndex("dbo.Plasma", new[] { "FormularCerere_Id" });
            DropIndex("dbo.GlobuleRosii", new[] { "FormularCerere_Id" });
            DropIndex("dbo.PungaSange", new[] { "CentruDonare_Id" });
            DropIndex("dbo.PungaSange", new[] { "Id" });
            DropIndex("dbo.Spital", new[] { "Adresa_Strada", "Adresa_Numar", "Adresa_Oras" });
            DropIndex("dbo.DateContact", new[] { "Adresa_Strada", "Adresa_Numar", "Adresa_Oras" });
            DropIndex("dbo.CentruDonare", new[] { "Adresa_Strada", "Adresa_Numar", "Adresa_Oras" });
            DropIndex("dbo.Donator", new[] { "DateContact_Id" });
            DropIndex("dbo.Donator", new[] { "CentruDonare_Id1" });
            DropIndex("dbo.Donator", new[] { "Account_Username" });
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
