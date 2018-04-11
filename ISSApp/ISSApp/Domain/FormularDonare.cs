using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class FormularDonare
    {
        public FormularDonare() { }

        [Key]
        public int Id { get; set; }
        public virtual PungaSange PungaSange { get; set; }
    }
}
