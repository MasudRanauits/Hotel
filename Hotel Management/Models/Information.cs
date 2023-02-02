using System.ComponentModel.DataAnnotations;

namespace Hotel_Management.Models
{
    public class Information
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
}
