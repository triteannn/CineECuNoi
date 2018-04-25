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

        public string Password { get; set; }

        public int IdD { get; set; }

        public int IdM { get; set; }

        public int IdAC { get; set; }

        [ForeignKey("IdD")]
        [InverseProperty("Account")]
        public virtual Donator Donator { get; set; }

        [ForeignKey("IdM")]
        [InverseProperty("Account")]
        public virtual Medic Medic { get; set; }

        [ForeignKey("IdAC")]
        [InverseProperty("Account")]
        public virtual AngajatCentru AngajatCentru { get; set; }
    }
}