using System.ComponentModel.DataAnnotations;

namespace Hotel_Management.Models
{
    public class PaymentType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "SL")]
        public int SLId { get; set; }
        [Required]
        [Display(Name = "Payment Type Title")]
        public string PaymentTypeTitle { get; set; }
    }
}
