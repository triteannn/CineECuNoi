using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("PungiSange")]
    public class PungaSange
    {
        public int Id { get; set; }
        public DateTime DataRecoltare { get; set; }
        public string Grupa { get; set; }
        public string Rh { get; set; }
        public string Target { get; set; }

        public int IdCd { get; set; }

        public virtual CentruDonare CentruDonare { get; set; }
        public virtual FormularDonare FormularDonare { get; set; }

        [NotMapped]
        public int IdFd { get; set; }
    }
}