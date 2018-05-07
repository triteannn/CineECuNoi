using Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Table("Spitale")]
    public class Spital : IInstitutie
    {
        public Spital()
        {
            Medici = new List<Medic>();
        }

        public int Id { get; set; }
        public string Denumire { get; set; }

        public int IdAdr { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual ICollection<Medic> Medici { get; set; }
    }
}