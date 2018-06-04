using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("PSPlasme")]
    public class PSPlasma : IProdusSanguin
    {
        public int Id { get; set; }
        public float Cantitate { get; set; }
        public string Target { get; set; }

        public DateTime DataExpirare { get; set; }
        public string Grupa { get; set; }
        public string Rh { get; set; }
        public int? IdCD { get; set; } //cheie catre centru donare

        public PSPlasma() { }

        public PSPlasma(int id, float quantity, string target, DateTime dataExpirare, string grupa, string rh, int? idCd)
        {
            Id = id;
            Cantitate = quantity;
            Target = target;
            DataExpirare = dataExpirare;
            Grupa = grupa;
            Rh = rh;
            IdCD = idCd;
        }

        public PSPlasma(float quantity, string target, DateTime dataExpirare, string grupa, string rh, int? idCd)
        {
            Cantitate = quantity;
            Target = target;
            DataExpirare = dataExpirare;
            Grupa = grupa;
            Rh = rh;
            IdCD = idCd;
        }

        public virtual CentruDonare CentruDonare { get; set; }
    }
}