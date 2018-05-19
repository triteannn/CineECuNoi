using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("FormulareDonare")]
    public class FormularDonare
    {
        public int Id { get; set; }
        public DateTime DataCreare { get; set; }
        public string ListaBoli { get; set; }
        //public int IdD { get; set; }

        public virtual PungaSange PungaSange { get; set; }
        public virtual Analiza Analiza { get; set; }
        public virtual Donator Donator { get; set; }

        [NotMapped]
        public int IdAn { get; set; }


    }
}
