using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Device.Location;

namespace ISSApp.Domain
{
    [Serializable]
    [Table("Adrese")]
    public class Adresa
    {
        public int Id { get; set; }
        public string Strada { get; set; }
        public int Numar { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public Adresa()
        {
        }

        public Adresa(int id, string strada, int numar, string oras, string judet)
        {
            Id = id;
            Strada = strada;
            Numar = numar;
            Oras = oras;
            Judet = judet;
        }

        public Adresa(string strada, int numar, string oras, string judet)
        {
            Strada = strada;
            Numar = numar;
            Oras = oras;
            Judet = judet;
        }

        /*
         * returneaza distanta in metri intre cele 2 adrese
         */
        public static double DistantaIntreAdrese(Adresa sursa, Adresa destinatie)
        {

            var sCoord = new GeoCoordinate(sursa.Latitude, sursa.Longitude);
            var eCoord = new GeoCoordinate(destinatie.Latitude, destinatie.Longitude);

            return sCoord.GetDistanceTo(eCoord);
        }

        public virtual Spital Spital { get; set; }
        public virtual CentruDonare CentruDonare { get; set; }
        public virtual DateContact DateContact { get; set; }
    }
}