
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    public interface IProdusSanguin {

        /**
         * 
         */
        DateTime DataRecoltare { get; set; }

        /**
         * 
         */
        float Cantitate { get; set; }

        /**
         * 
         */
        string Target { get; set; }

    }
}