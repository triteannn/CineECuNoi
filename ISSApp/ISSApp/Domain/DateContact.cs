using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("DateContact")]
    public class DateContact
    {
        public int Id { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual Donator Donator { get; set; }
        public virtual Medic Medic { get; set; }
        public virtual AngajatCentru AngajatCentru { get; set; }

        [NotMapped]
        public int IdAdr { get; set; }
    }
}