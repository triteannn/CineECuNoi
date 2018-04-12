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
    [Table("GlobuleRosii")]
    public class PSGlobuleRosii : IProdusSanguin {

        /**
         * 
         */
        public PSGlobuleRosii() {}

        [Key]
        public int Id { get; set; }
        public DateTime DataRecoltare { get; set; }
        public float Cantitate { get; set; }
        public string Target { get; set; }
        public FormularCerere FormularCerere { get; set; }
    }
}