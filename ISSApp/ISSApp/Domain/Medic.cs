
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    [Table("Medic")]
    public class Medic : Donator {

        /**
         * 
         */
        public Medic() {}

        public virtual Spital Spital { get; set; }

    }
}