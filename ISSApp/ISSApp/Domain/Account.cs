using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * Account entity.
     */
    [Table("Account")]
    public class Account {

        /**
         * Constructor.
         */
        public Account() {}

        /**
         * 
         */
        [Key]
        public int IdA { get; set; }

        public string Username { get; set; }

        /**
         * 
         */
        public string Password { get; set; }

       // public virtual IPersoana Persoana { get; set; }

        public virtual Donator Donator { get; set; }

        public virtual Medic Medic { get; set; }

        public virtual AngajatCentru AngajatCentru { get; set; }
    }
}