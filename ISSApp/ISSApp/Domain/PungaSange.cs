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
    [Table("PungaSange")]
    public class PungaSange {

        /**
         * 
         */
        public PungaSange() {}

        /**
         * 
         */
        [Key, ForeignKey("FormularDonare")]
        public int Id { get; set; }

        public DateTime DataRecoltare { get; set; }

        /**
         * 
         */
        public string Grupa { get; set; }

        /**
         * 
         */
        public string Rh { get; set; }

        /**
         * 
         */
        public string Target { get; set; }

        public virtual CentruDonare CentruDonare { get; set; }

        public virtual FormularDonare FormularDonare { get; set; }

    }
}