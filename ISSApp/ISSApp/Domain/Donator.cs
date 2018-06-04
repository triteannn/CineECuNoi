using Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("Donatori")]
    public class Donator : IPersoana
    {
        public Donator() { }

        public Donator(string cnp, string nume, string prenume, DateTime dob)
        {
            CNP = cnp;
            Nume = nume;
            Prenume = prenume;
            Dob = dob;
        }

        public Donator(int id, string cnp, string nume, string prenume, DateTime dob)
        {
            Id = id;
            CNP = cnp;
            Nume = nume;
            Prenume = prenume;
            Dob = dob;
        }

        public Donator(int id, string cnp, string nume, string prenume, DateTime dob, int? idA, int? idDc, int? idCd)
        {
            Id = id;
            CNP = cnp;
            Nume = nume;
            Prenume = prenume;
            Dob = dob;
            IdA = idA;
            IdDc = idDc;
            IdCd = idCd;
        }

        public Donator(int id, string cnp, string nume, string prenume, DateTime dob, int? idA, int? idDc, int? idCd, string grupa, string rh)
        {
            Id = id;
            CNP = cnp;
            Nume = nume;
            Prenume = prenume;
            Dob = dob;
            IdA = idA;
            IdDc = idDc;
            IdCd = idCd;
            Grupa = grupa;
            Rh = rh;
        }

        public int Id { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }
        public string Grupa { get; set; }
        public string Rh { get; set; }

        //public int IdA { get; set; }
        public int? IdCd { get; set; }

        public virtual DateContact DateContact { get; set; }
        public virtual Account Account { get; set; }
        public virtual CentruDonare CentruDonare { get; set; }
        public virtual FormularDonare FormularDonare { get; set; }

        [NotMapped]
        public int? IdDc { get; set; }

        [NotMapped]
        public int? IdA { get; set; }
    }
}