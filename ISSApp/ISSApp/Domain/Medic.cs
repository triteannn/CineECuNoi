using Domain;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("Medici")]
    public class Medic : IPersoana
    {
        public int Id { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }

        public int IdA { get; set; }
        public int IdS { get; set; }

        public virtual DateContact DateContact { get; set; }
        public virtual Account Account { get; set; }
        public virtual Spital Spital { get; set; }

        [NotMapped]
        public int IdDc { get; set; }
    }
}