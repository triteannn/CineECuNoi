using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * Account entity.
     */
    public class Account {

        /**
         * Constructor.
         */
        public Account() {}

        /**
         * 
         */
        [Key]
        public string Username { get; set; }

        /**
         * 
         */
        public string Password { get; set; }

        public virtual IPersoana Persoana { get; set; }
    }
}