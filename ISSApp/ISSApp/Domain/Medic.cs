
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
    [Table("Medic")]
    public class Medic : IPersoana {

        /**
         * 
         */
        public Medic() {}

        [Key, ForeignKey("Account")]
        public int IdM { get; set; }
        public string CNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime Dob { get; set; }
        public DateContact DateContact { get; set; }

        public virtual Account Account { get; set; }
        public virtual Spital Spital { get; set; }
    }
}