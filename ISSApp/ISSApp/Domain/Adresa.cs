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
    [Table("Adresa")]
    public class Adresa {

        /**
         * 
         */
        public Adresa() {}

        /**
         * 
         */
        [Key]
        public int IdA { get; set; }

        public string Strada { get; set; }

        /**
         * 
         */
        public int Numar { get; set; }

        /**
         * 
         */
        public string Oras { get; set; }

        /**
         * 
         */
        public string Judet { get; set; }

    }
}