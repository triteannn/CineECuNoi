using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("FormularCerere")]
    public class FormularCerere
    {
        public FormularCerere() { }


        [Key]
        public int IdFC { get; set; }
        public virtual IProdusSanguin ProdusSanguin { get; set; }
    }
}
