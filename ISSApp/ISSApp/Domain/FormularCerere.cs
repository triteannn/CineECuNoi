using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FormularCerere
    {
        public FormularCerere() { }


        [Key]
        public int Id { get; set; }
        public virtual IProdusSanguin ProdusSanguin { get; set; }
    }
}
