using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Hotel_Management.Models
{
    public class GuestTypeDiscount
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Discount { get; set; }
        [Display(Name = "Guest Type")]
        [Required]
        public int GuestTypeId { get; set; }
        [ForeignKey("GuestTypeId")]
        public virtual GuestType GuestType { get; set; }
    }
}
