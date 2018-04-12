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
    [Table("DateContact")]
    public class DateContact {

        /**
         * 
         */
        public DateContact() {}

        /**
         * 
         */
        
        [Key, ForeignKey("Adresa")]
        public int IdDC { get; set; }

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