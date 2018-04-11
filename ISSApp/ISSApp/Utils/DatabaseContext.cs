using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace ISSApp.Utils
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Donator> Donatori { get; set; }
        public DbSet<Medic> Medici { get; set; }
        public DbSet<AngajatCentru> Angajati { get; set; }
        public DbSet<DateContact> DateContact { get; set; }
        public DbSet<Spital> Spitale { get; set; }
        public DbSet<CentruDonare> CentreDonare { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<PSTrombocite> Trombocite { get; set; }
        public DbSet<PSGlobuleRosii> GlobuleRosii { get; set; }
        public DbSet<PSPlasma> Plasma { get; set; }
        public DbSet<PungaSange> PungiSange { get; set; }
        public DbSet<FormularDonare> FormulareDonare { get; set; }
        public DbSet<FormularCerere> FormulareCerere { get; set; }
    }
}
