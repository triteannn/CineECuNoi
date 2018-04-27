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
    [Table("Angajat")]
    public class AngajatCentru :IPersoana {

        /**
         * 
         */
        public AngajatCentru() {}

        [Key, ForeignKey("Account")]
        public int IdAC { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }
        public DateContact DateContact { get; set; }

        public virtual Account Account { get; set; }
        public virtual CentruDonare CentruDonare { get; set; }

    }
}