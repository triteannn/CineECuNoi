using ISSApp.Domain;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Server
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Server=den1.mssql3.gear.host; user=donaresangeiss; password=pistaislove@; database=donaresangeiss;")
        {

        }

        public DbSet<Account> Account { get; set; }
        public DbSet<Donator> Donator { get; set; }
        public DbSet<Medic> Medic { get; set; }
        public DbSet<AngajatCentru> Angajat { get; set; }
        public DbSet<DateContact> DateContact { get; set; }
        public DbSet<Spital> Spital { get; set; }
        public DbSet<CentruDonare> CentruDonare { get; set; }
        public DbSet<Adresa> Adresa { get; set; }
        public DbSet<PSTrombocite> Trombocite { get; set; }
        public DbSet<PSGlobuleRosii> GlobuleRosii { get; set; }
        public DbSet<PSPlasma> Plasma { get; set; }
        public DbSet<PungaSange> PungaSange { get; set; }
        public DbSet<FormularDonare> FormularDonare { get; set; }
        public DbSet<FormularCerere> FormularCerere { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasKey(t => t.Id);
            modelBuilder.Entity<Account>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Account>().Property(t => t.IdAc).IsOptional();
            modelBuilder.Entity<Account>().Property(t => t.IdM).IsOptional();
            modelBuilder.Entity<Account>().Property(t => t.IdD).IsOptional();
            //modelBuilder.Entity<Account>().HasOptional(t => t.Donator).WithRequired(t => t.Account);
            //modelBuilder.Entity<Account>().HasOptional(t => t.AngajatCentru).WithRequired(t => t.Account);
            //modelBuilder.Entity<Account>().HasOptional(t => t.Medic).WithRequired(t => t.Account);

            modelBuilder.Entity<Adresa>().HasKey(t => t.Id);
            modelBuilder.Entity<Adresa>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<AngajatCentru>().HasKey(t => t.Id);
            modelBuilder.Entity<AngajatCentru>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<AngajatCentru>().HasRequired(t => t.Account).WithOptional(t => t.AngajatCentru).Map(t => t.MapKey("IdA")).WillCascadeOnDelete(true); //
            modelBuilder.Entity<AngajatCentru>().HasRequired(t => t.CentruDonare).WithMany(t => t.Angajati).HasForeignKey(t => t.IdCd); //
            modelBuilder.Entity<AngajatCentru>().HasRequired(t => t.DateContact).WithOptional(t => t.AngajatCentru).Map(t => t.MapKey("IdDc"));

            modelBuilder.Entity<CentruDonare>().HasKey(t => t.Id);
            modelBuilder.Entity<CentruDonare>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<CentruDonare>().HasRequired(t => t.Adresa).WithOptional(t => t.CentruDonare).Map(t => t.MapKey("IdAdr"));


            modelBuilder.Entity<DateContact>().HasKey(t => t.Id);
            modelBuilder.Entity<DateContact>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<DateContact>().HasRequired(t => t.Adresa).WithOptional(t => t.DateContact).Map(t => t.MapKey("IdAdr"));

            modelBuilder.Entity<Donator>().HasKey(t => t.Id);
            modelBuilder.Entity<Donator>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Donator>().HasRequired(t => t.DateContact).WithOptional(t => t.Donator).Map(t => t.MapKey("IdDc"));
            modelBuilder.Entity<Donator>().HasRequired(t => t.Account).WithOptional(t => t.Donator).Map(t => t.MapKey("IdA")).WillCascadeOnDelete(true); //
            modelBuilder.Entity<Donator>().HasOptional(t => t.CentruDonare).WithMany(t => t.Donatori).HasForeignKey(t => t.IdCd);
            modelBuilder.Entity<Donator>().Property(t => t.Grupa).IsOptional();
            modelBuilder.Entity<Donator>().Property(t => t.Rh).IsOptional();

            modelBuilder.Entity<FormularCerere>().HasKey(t => t.Id);
            modelBuilder.Entity<FormularCerere>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<FormularCerere>().HasRequired(t => t.Medic).WithOptional(t => t.FormularCerere).Map(t => t.MapKey("IdM"));
            modelBuilder.Entity<FormularCerere>().Property(t => t.Status).IsOptional();

            modelBuilder.Entity<FormularDonare>().HasKey(t => t.Id);
            modelBuilder.Entity<FormularDonare>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<FormularDonare>().HasOptional(t => t.PungaSange).WithRequired(t => t.FormularDonare);
            modelBuilder.Entity<FormularDonare>().HasRequired(t => t.Analiza).WithOptional(t => t.FormularDonare).Map(t => t.MapKey("IdAn"));
            modelBuilder.Entity<FormularDonare>().HasRequired(t => t.Donator).WithOptional(t => t.FormularDonare).Map(t => t.MapKey("IdD"));

            modelBuilder.Entity<Medic>().HasKey(t => t.Id);
            modelBuilder.Entity<Medic>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Medic>().HasRequired(t => t.DateContact).WithOptional(t => t.Medic).Map(t => t.MapKey("IdDc"));
            modelBuilder.Entity<Medic>().HasRequired(t => t.Account).WithOptional(t => t.Medic).Map(t => t.MapKey("IdA")).WillCascadeOnDelete(true); //
            modelBuilder.Entity<Medic>().HasRequired(t => t.Spital).WithMany(t => t.Medici).HasForeignKey(t => t.IdS);

            modelBuilder.Entity<PSGlobuleRosii>().HasKey(t => t.Id);
            modelBuilder.Entity<PSGlobuleRosii>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<PSGlobuleRosii>().HasRequired(t => t.CentruDonare).WithMany(t => t.GlobuleRosii).HasForeignKey(t => t.IdCD);

            modelBuilder.Entity<PSPlasma>().HasKey(t => t.Id);
            modelBuilder.Entity<PSPlasma>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<PSPlasma>().HasRequired(t => t.CentruDonare).WithMany(t => t.Plasme).HasForeignKey(t => t.IdCD);

            modelBuilder.Entity<PSTrombocite>().HasKey(t => t.Id);
            modelBuilder.Entity<PSTrombocite>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<PSTrombocite>().HasRequired(t => t.CentruDonare).WithMany(t => t.Trombocite).HasForeignKey(t => t.IdCD);

            modelBuilder.Entity<PungaSange>().HasKey(t => t.Id);
            modelBuilder.Entity<PungaSange>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<PungaSange>().HasRequired(t => t.CentruDonare).WithMany(t => t.PungiSange).HasForeignKey(t => t.IdCd);
            modelBuilder.Entity<PungaSange>().HasRequired(t => t.FormularDonare).WithOptional(t => t.PungaSange).Map(t => t.MapKey("IdFd"));

            modelBuilder.Entity<Spital>().HasKey(t => t.Id);
            modelBuilder.Entity<Spital>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Spital>().HasRequired(t => t.Adresa).WithOptional(t => t.Spital).Map(t => t.MapKey("IdAdr"));

            modelBuilder.Entity<Analiza>().HasKey(t => t.Id);
            modelBuilder.Entity<Analiza>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
