using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("PSTrombocite")]
    public class PSTrombocite : IProdusSanguin
    {

        public int Id { get; set; }
        //        public DateTime DataRecoltare { get; set; }
        public float Cantitate { get; set; }
        public string Target { get; set; }

        //        public int? IdFc { get; set; }

        //        public virtual FormularCerere FormularCerere { get; set; }

        public DateTime DataExpirare { get; set; }
        public string Grupa { get; set; }
        public string Rh { get; set; }
        public int? IdCD { get; set; } //cheie catre centru donare

        public virtual CentruDonare CentruDonare { get; set; }

        public PSTrombocite(int id, float cantitate, string target, DateTime dataExpirare, string grupa, string rh, int? idCd)
        {
            Id = id;
            Cantitate = cantitate;
            Target = target;
            DataExpirare = dataExpirare;
            Grupa = grupa;
            Rh = rh;
            IdCD = idCd;
        }

        public PSTrombocite(float cantitate, string target, DateTime dataExpirare, string grupa, string rh, int? idCd)
        {
            Cantitate = cantitate;
            Target = target;
            DataExpirare = dataExpirare;
            Grupa = grupa;
            Rh = rh;
            IdCD = idCd;
        }

        public PSTrombocite() { }
    }
}