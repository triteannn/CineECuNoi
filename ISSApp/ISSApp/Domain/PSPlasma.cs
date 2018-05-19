using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("PSPlasme")]
    public class PSPlasma : IProdusSanguin
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

    }
}