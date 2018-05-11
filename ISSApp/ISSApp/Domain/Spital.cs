using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("Spitale")]
    public class Spital : IInstitutie
    {
        public Spital()
        {
            Medici = new List<Medic>();
        }

        public int Id { get; set; }
        public string Denumire { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual ICollection<Medic> Medici { get; set; }

        [NotMapped]
        public int IdAdr { get; set; }

        public Spital(int id, string denumire)
        {
            Id = id;
            Denumire = denumire;
            Medici = new List<Medic>();
        }
    }
}