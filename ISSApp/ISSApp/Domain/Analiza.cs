using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("Analize")]
    public class Analiza
    {
        public Analiza(int id, DateTime dataRecoltarii, double eritrocite, double hemoglobina, double hematocrit, double vEM, double hEM, double cHEM, double latimeDistribEritrocit, double trombocite, double volumMediuTrombocitar, double trombocrit, double latimeDistribTrombocit, double leucocite, double granulocite, double limfocite, double mID, double numarGranulocite, double numarLimfocite, double numarMID, double glicemie, double aLT_TGP, double colesterol)
        {
            Id = id;
            DataRecoltarii = dataRecoltarii;
            Eritrocite = eritrocite;
            Hemoglobina = hemoglobina;
            Hematocrit = hematocrit;
            VEM = vEM;
            HEM = hEM;
            CHEM = cHEM;
            LatimeDistribEritrocit = latimeDistribEritrocit;
            Trombocite = trombocite;
            VolumMediuTrombocitar = volumMediuTrombocitar;
            Trombocrit = trombocrit;
            LatimeDistribTrombocit = latimeDistribTrombocit;
            Leucocite = leucocite;
            Granulocite = granulocite;
            Limfocite = limfocite;
            MID = mID;
            NumarGranulocite = numarGranulocite;
            NumarLimfocite = numarLimfocite;
            NumarMID = numarMID;
            Glicemie = glicemie;
            ALT_TGP = aLT_TGP;
            Colesterol = colesterol;
        }

        public int Id { get; set; }
        public DateTime DataRecoltarii { get; set; }
        public double Eritrocite { get; set; }
        public double Hemoglobina { get; set; }
        public double Hematocrit { get; set; }
        public double VEM { get; set; }
        public double HEM { get; set; }
        public double CHEM { get; set; }
        public double LatimeDistribEritrocit { get; set; }
        public double Trombocite { get; set; }
        public double VolumMediuTrombocitar { get; set; }
        public double Trombocrit { get; set; }
        public double LatimeDistribTrombocit { get; set; }
        public double Leucocite { get; set; }
        public double Granulocite { get; set; }
        public double Limfocite { get; set; }
        public double MID { get; set; }
        public double NumarGranulocite { get; set; }
        public double NumarLimfocite { get; set; }
        public double NumarMID { get; set; }
        public double Glicemie { get; set; }
        public double ALT_TGP { get; set; }
        public double Colesterol { get; set; }

        public virtual FormularDonare FormularDonare { get; set; }
    }
}
