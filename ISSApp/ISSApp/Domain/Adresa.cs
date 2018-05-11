using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("Adrese")]
    public class Adresa
    {
        public int Id { get; set; }
        public string Strada { get; set; }
        public int Numar { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }

        public virtual Spital Spital { get; set; }
        public virtual CentruDonare CentruDonare { get; set; }
        public virtual DateContact DateContact { get; set; }
    }
}