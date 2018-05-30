using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISSApp.Domain
{
    public class PungaSangeCuCNP
    {
        public string CNP { get; set; }
        public int Id { get; set; }
        public DateTime DataRecoltare { get; set; }
        public string Grupa { get; set; }
        public string Rh { get; set; }
        public string Target { get; set; }

        public PungaSangeCuCNP() { }

        public PungaSangeCuCNP(string CNP, int id, DateTime DataRecoltare, string grupa, string rh, string target)
        {
            this.CNP = CNP;
            this.Id = id;
            this.DataRecoltare = DataRecoltare;
            this.Grupa = grupa;
            this.Target = target;
            this.Rh = rh;
            this.Target = target;
        }
    }
}
