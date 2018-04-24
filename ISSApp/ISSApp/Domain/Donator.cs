using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    [Table("Donator")]
    public class Donator : IPersoana {

        /**
         * 
         */
        public Donator() {}



        [Key, ForeignKey("Account")]
        public int IdD { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }     
        public DateContact DateContact { get; set; }
        public virtual Account Account { get; set; }

        public virtual CentruDonare CentruDonare { get; set; }
    }
}