﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("FormulareCerere")]
    public class FormularCerere
    {
        public FormularCerere()
        {
            //            PsPlasme = new List<PSPlasma>();
            //            PsGlobuleRosii = new List<PSGlobuleRosii>();
            //            PsTrombocite = new List<PSTrombocite>();
        }

        public int Id { get; set; }

        //
        //        public virtual ICollection<PSPlasma> PsPlasme { get; set; }
        //        public virtual ICollection<PSGlobuleRosii> PsGlobuleRosii { get; set; }
        //        public virtual ICollection<PSTrombocite> PsTrombocite { get; set; }

        public string Target { get; set; }

        [NotMapped]
        public int IdM { get; set; }  //is this gut?

        public double CantTrombocite { get; set; }
        public double CantPlasma { get; set; }
        public double CantGlobuleRosii { get; set; }
        public string Status { get; set; }

        public string Grupa { get; set; }

        public string Rh { get; set; }

        public virtual Medic Medic { get; set; }

        public FormularCerere(int id, string target, double? cantTrombocite, double? cantPlasma, double? cantGlobuleRosi, int? idM, string status, string grupa, string rh)
        {
            Id = id;
            Target = target;
            CantTrombocite = (double) cantTrombocite;
            CantPlasma = (double) cantPlasma;
            CantGlobuleRosii = (double) cantGlobuleRosi;
            IdM = (int) idM;
            Status = status;
            Grupa = grupa;
            Rh = rh;
        }
    }
}
