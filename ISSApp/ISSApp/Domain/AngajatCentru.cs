using Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("AngajatiCentru")]
    public class AngajatCentru : IPersoana
    {

        public AngajatCentru() { }

        public AngajatCentru(string cNP, string nume, string prenume, DateTime dob)
        {
            CNP = cNP;
            Nume = nume;
            Prenume = prenume;
            Dob = dob;
        }

        public int Id { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }

        public int IdCd { get; set; }

        public virtual Account Account { get; set; }
        public virtual CentruDonare CentruDonare { get; set; }
        public virtual DateContact DateContact { get; set; }

        [NotMapped]
        public int IdDc { get; set; }

        [NotMapped]
        public int IdA { get; set; }
    }
}