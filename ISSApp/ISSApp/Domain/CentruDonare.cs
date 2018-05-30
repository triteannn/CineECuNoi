using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("CentreDonare")]
    public class CentruDonare : IInstitutie
    {
        public CentruDonare()
        {
            Angajati = new List<AngajatCentru>();
            Donatori = new List<Donator>();
            PungiSange = new List<PungaSange>();
        }

        public CentruDonare(int id, string denumire)
        {
            Id = id;
            Denumire = denumire;
            //IdAdr = idAdr;

            Angajati = new List<AngajatCentru>();
            Donatori = new List<Donator>();
            PungiSange = new List<PungaSange>();
        }
        public CentruDonare(int id, string denumire,int? idAdr)
        {
            Id = id;
            Denumire = denumire;
            IdAdr = idAdr;

            Angajati = new List<AngajatCentru>();
            Donatori = new List<Donator>();
            PungiSange = new List<PungaSange>();
        }

        public int Id { get; set; }
        public string Denumire { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual ICollection<AngajatCentru> Angajati { get; set; }
        public virtual ICollection<Donator> Donatori { get; set; }
        public virtual ICollection<PungaSange> PungiSange { get; set; }

        public virtual ICollection<PSGlobuleRosii> GlobuleRosii { get; set; }
        public virtual ICollection<PSPlasma> Plasme { get; set; }
        public virtual ICollection<PSTrombocite> Trombocite { get; set; }

        [NotMapped]
        public int? IdAdr { get; set; }
    }
}