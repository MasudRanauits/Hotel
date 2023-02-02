using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Hotel_Management.Models
{
    public class HotelService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "SL")]
        public int SLId { get; set; }
        [Required]
        [Display(Name = "Service Name")]
        public string ServiceName { get; set; }
        [Required]
        [Display(Name = "Per/Unit Price")]
        public int PerUnitPrice { get; set; }
    }
}
