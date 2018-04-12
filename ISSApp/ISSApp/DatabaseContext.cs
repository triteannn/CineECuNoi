using System.Data.Entity;
using Domain;

namespace ISSApp
{
    public class DatabaseContext : DbContext
    {
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
    }
}
