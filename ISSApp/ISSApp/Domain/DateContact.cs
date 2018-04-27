using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    /**
     * 
     */
    [Table("DateContact")]
    public class DateContact
    {

        /**
         * 
         */
        public DateContact() { }

        /**
         * 
         */

        [Key]
        public int IdDC { get; set; }

        public string Telefon { get; set; }

        /**
         * 
         */
        public string Email { get; set; }

        /**
         * 
         */
        public virtual Adresa Adresa { get; set; }

        public virtual IPersoana Persoana { get; set; }
    }
}