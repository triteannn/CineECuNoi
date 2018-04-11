using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    public class AngajatCentru : Donator {

        /**
         * 
         */
        public AngajatCentru() {}

        public override CentruDonare CentruDonare { get; set; }
    }
}