using Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Table("AngajatiCentru")]
    public class AngajatCentru : IPersoana
    {
        public int Id { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }

        public int IdA { get; set; }
        public int IdCd { get; set; }
        //public int IdDc { get; set; }

        public virtual Account Account { get; set; }
        public virtual CentruDonare CentruDonare { get; set; }
        public virtual DateContact DateContact { get; set; }
    }
}