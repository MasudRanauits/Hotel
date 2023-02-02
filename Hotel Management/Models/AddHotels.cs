using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Management.Models
{
    public class AddHotels
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        [Display(Name = "Contact No")]
        public int ContactNo { get; set; }
        [Display(Name = "Fax Number")]
        public int FaxNumber { get; set; }
        public int Phone { get; set; }
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        [Display(Name = "Vat Reg No")]
        public int VatRegNo { get; set; }
        [Display(Name = "Area Code")]
        public int AreaCode { get; set; }
        [Display(Name = "Reataurant Name")]
        public string RestaurantName { get; set; }
        public int Capacity { get; set; }
        [Display(Name = "SSL Store Id")]
        public int SSLStoreId { get; set; }
        [Display(Name = "SSL Password")]
        public string SSLPassword { get; set; }
        public string Description { get; set; }
    }
}
