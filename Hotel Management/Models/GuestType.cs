using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Hotel_Management.Models
{
    public class GuestType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "SL")]
        public int SLId { get; set; }
        [Required]
        [Display(Name = "Guest Type Title")]
        public string GuestTypesTitle { get; set; }
    }
}
