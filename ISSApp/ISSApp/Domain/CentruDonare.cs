using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Domain{
    /**
     * 
     */
    [Table("CentruDonare")]
    public class CentruDonare : IInstitutie {

        /**
         * 
         */
        public CentruDonare()
        {
            Angajati = new List<AngajatCentru>();
            Donatori = new List<Donator>();
            PungiSange = new List<PungaSange>();
        }

        [Key, ForeignKey("Adresa")]
        public int IdCD { get; set; }
        public string Denumire { get; set; }
        public virtual Adresa Adresa { get; set; }

        public virtual List<AngajatCentru> Angajati { get; set; }
        public virtual List<Donator> Donatori { get; set; }
        public virtual List<PungaSange> PungiSange { get; set; }
    }
}