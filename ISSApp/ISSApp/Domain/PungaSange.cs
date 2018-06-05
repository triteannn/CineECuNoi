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

        public PungaSange(int id, DateTime dataRecoltare, string grupa, string rh, string target, int idCd, int idFd)
        {
            Id = id;
            DataRecoltare = dataRecoltare;
            Grupa = grupa;
            Rh = rh;
            Target = target;
            IdCd = idCd;
            IdFd = idFd;
        }

        public PungaSange(DateTime dataRecoltare, string grupa, string rh, string target, int idCd, int idFd)
        {
            DataRecoltare = dataRecoltare;
            Grupa = grupa;
            Rh = rh;
            Target = target;
            IdCd = idCd;
            IdFd = idFd;
        }

        public PungaSange(DateTime DataRecoltare, string Target, int IdCd, int IdFd)
        {
            this.DataRecoltare = DataRecoltare;
            this.Target = Target;
            this.IdCd = IdCd;
            this.IdFd = IdFd;

            this.Grupa = null;
            this.Rh = null;
        }

        public PungaSange(DateTime DataRecoltare, int IdCd, int IdFd)
        {
            this.DataRecoltare = DataRecoltare;
            this.IdCd = IdCd;
            this.IdFd = IdFd;

            this.Target = null;
            this.Grupa = null;
            this.Rh = null;
        }

        public PungaSange()
        {
        }
    }
}