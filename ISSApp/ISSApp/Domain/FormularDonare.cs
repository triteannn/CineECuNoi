﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("FormulareDonare")]
    public class FormularDonare
    {
        public FormularDonare(int id, DateTime dataCreare, string listaBoli, int? idAn, int? idD, string target, string status)
        {
            Id = id;
            DataCreare = dataCreare;
            ListaBoli = listaBoli;
            IdAn = idAn;
            IdD = idD;
            Target = target;
            Status = status;
        }

        public FormularDonare(DateTime dataCreare, string listaBoli, int? idAn, int? idD, string target)
        {
            DataCreare = dataCreare;
            ListaBoli = listaBoli;
            IdAn = idAn;
            IdD = idD;
            Target = target;
        }


        public int Id { get; set; }
        public DateTime DataCreare { get; set; }
        public string ListaBoli { get; set; }

        //[NotMapped]
        //public int IdD { get; set; } //modificat aici 

        public virtual PungaSange PungaSange { get; set; }
        public virtual Analiza Analiza { get; set; }
        public virtual Donator Donator { get; set; }

        [NotMapped]
        public int? IdAn { get; set; }
        [NotMapped]
        public int? IdD { get; set; }

        public string Target { get; set; }

        public string Status { get; set; }


    }
}
