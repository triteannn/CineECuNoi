using System.ComponentModel.DataAnnotations.Schema;

namespace ISSApp.Domain
{
    [Table("FormulareDonare")]
    public class FormularDonare
    {
        public int Id { get; set; }

        public virtual PungaSange PungaSange { get; set; }
    }
}
