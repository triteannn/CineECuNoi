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

        public int IdS { get; set; }

        public int IdCD { get; set; }

        public int IdDC { get; set; }

        [ForeignKey("IdS")]
        [InverseProperty("Adresa")]
        public virtual Spital Spital { get; set; }

        [ForeignKey("IdCD")]
        [InverseProperty("Adresa")]
        public virtual CentruDonare CentruDonare { get; set; }

        [ForeignKey("IdDC")]
        [InverseProperty("Adresa")]
        public virtual DateContact DateContact { get; set; }
    }
}