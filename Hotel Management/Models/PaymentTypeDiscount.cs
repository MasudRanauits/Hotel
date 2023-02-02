using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Hotel_Management.Models
{
    public class PaymentTypeDiscount
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Discount { get; set; }
        [Display(Name = "Payment Type")]
        [Required]
        public int PaymentTypeId { get; set; }
        [ForeignKey("PaymentTypeId")]
        public virtual PaymentType PaymentType { get; set; }
    }
}
