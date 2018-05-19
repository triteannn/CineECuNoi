using System;
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
        //public int IdM { get; set; }

        public double CantTrombocite { get; set; }
        public double CantPlasma { get; set; }
        public double CantGlobuleRosii { get; set; }

        public virtual Medic Medic { get; set; }
    }
}
