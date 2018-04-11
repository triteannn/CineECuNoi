
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    public interface IInstitutie {

        /**
         * 
         */
        string Denumire { get; set; }

        /**
         * 
         */
        Adresa Adresa { get; set; }

    }
}