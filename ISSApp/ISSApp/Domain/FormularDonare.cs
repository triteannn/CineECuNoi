using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("FormulareDonare")]
    public class FormularDonare
    {
        public FormularDonare(DateTime dataCreare,string listaBoli,int idD)
        {
            DataCreare = dataCreare;
            ListaBoli = listaBoli;
            IdD = idD;
        }

        public int Id { get; set; }
        public DateTime DataCreare { get; set; }
        public string ListaBoli { get; set; }
        //public int IdD { get; set; }

        public virtual PungaSange PungaSange { get; set; }
        public virtual Analiza Analiza { get; set; }
        public virtual Donator Donator { get; set; }

        [NotMapped]
        public int IdAn { get; set; }
        [NotMapped]
        public int IdD { get; set; }


    }
}
