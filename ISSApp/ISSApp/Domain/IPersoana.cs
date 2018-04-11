
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    public interface IPersoana {

        /**
         * 
         */
        string CNP { get; set; }

        /**
         * 
         */
        string Nume { get; set; }

        /**
         * 
         */
        string Prenume { get; set; }

        /**
         * 
         */
        DateTime Dob { get; set; }

        /**
         * 
         */
        DateContact DateContact { get; set; }

        /**
         * 
         */
        Account Account { get; set; }

    }
}