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
        [Column(Order = 1)]
        public string Strada { get; set; }

        /**
         * 
         */
        [Key]
        [Column(Order = 2)]
        public int Numar { get; set; }

        /**
         * 
         */
        [Key]
        [Column(Order = 3)]
        public string Oras { get; set; }

        /**
         * 
         */
        public string Judet { get; set; }

    }
}