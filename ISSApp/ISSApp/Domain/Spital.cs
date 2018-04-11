using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    public class Spital : IInstitutie {

        /**
         * 
         */
        public Spital()
        {
            Medici = new List<Medic>();
        }


        [Key]
        public int Id { get; set; }
        public string Denumire { get; set; }
        public virtual Adresa Adresa { get; set; }

        public virtual List<Medic> Medici { get; set; }
    }
}