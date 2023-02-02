using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Hotel_Management.Models
{
    public class BaseDiscount
    {
        [Key]
        public int BaseDiscountId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Discount(%)")]
        public double Discount { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
