using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("PSGlobuleRosii")]
    public class PSGlobuleRosii : IProdusSanguin
    {
        public int Id { get; set; }
        public DateTime DataRecoltare { get; set; }
        public float Cantitate { get; set; }
        public string Target { get; set; }

        public int? IdFc { get; set; }

        public virtual FormularCerere FormularCerere { get; set; }
    }
}