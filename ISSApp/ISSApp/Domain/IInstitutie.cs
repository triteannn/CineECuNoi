
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISSApp.Domain;

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