using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    [Table("Angajat")]
    public class AngajatCentru : Donator {

        /**
         * 
         */
        public AngajatCentru() {}

        public override CentruDonare CentruDonare { get; set; }
    }
}