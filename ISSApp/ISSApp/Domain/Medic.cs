
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    public class Medic : Donator {

        /**
         * 
         */
        public Medic() {}

        public virtual Spital Spital { get; set; }

    }
}