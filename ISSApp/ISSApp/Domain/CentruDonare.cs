using Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Table("CentreDonare")]
    public class CentruDonare : IInstitutie
    {
        public CentruDonare()
        {
            Angajati = new List<AngajatCentru>();
            Donatori = new List<Donator>();
            PungiSange = new List<PungaSange>();
        }

        public CentruDonare(int _Id, string _Denumire, int _IdAdr)
        {
            Id = _Id;
            Denumire = _Denumire;
            IdAdr = _IdAdr;

            Angajati = new List<AngajatCentru>();
            Donatori = new List<Donator>();
            PungiSange = new List<PungaSange>();
        }

        public int Id { get; set; }
        public string Denumire { get; set; }

        public int IdAdr { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual ICollection<AngajatCentru> Angajati { get; set; }
        public virtual ICollection<Donator> Donatori { get; set; }
        public virtual ICollection<PungaSange> PungiSange { get; set; }
    }
}