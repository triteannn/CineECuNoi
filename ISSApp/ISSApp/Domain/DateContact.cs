using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    public class DateContact {

        /**
         * 
         */
        public DateContact() {}

        /**
         * 
         */
        
        [Key]
        public int Id { get; set; }

        public string Telefon { get; set; }

        /**
         * 
         */
        public string Email { get; set; }

        /**
         * 
         */
        public virtual Adresa Adresa { get; set; }

        public virtual IPersoana Persoana { get; set; }
    }
}