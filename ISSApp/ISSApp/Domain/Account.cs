using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Table("Accounts")]
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int IdD { get; set; }
        public int IdM { get; set; }
        public int IdAc { get; set; }

        public virtual Donator Donator { get; set; }
        public virtual Medic Medic { get; set; }
        public virtual AngajatCentru AngajatCentru { get; set; }
    }
}