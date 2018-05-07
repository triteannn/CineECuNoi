using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Table("DateContact")]
    public class DateContact
    {
        public int Id { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public int IdAdr { get; set; }
        public int IdD { get; set; }
        public int IdM { get; set; }
        public int IdAc { get; set; }

        public virtual Adresa Adresa { get; set; }
        public virtual Donator Donator { get; set; }
        public virtual Medic Medic { get; set; }
        public virtual AngajatCentru AngajatCentru { get; set; }
    }
}