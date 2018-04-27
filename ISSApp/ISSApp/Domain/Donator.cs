using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    /**
     * 
     */
    [Table("Donator")]
    public class Donator : IPersoana
    {

        /**
         * 
         */
        public Donator() { }



        [Key]
        public int IdD { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }
        public DateContact DateContact { get; set; }

        [ForeignKey("Account")]
        public virtual Account Account { get; set; }
        public virtual CentruDonare CentruDonare { get; set; }
    }
}