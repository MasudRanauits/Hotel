using System.ComponentModel.DataAnnotations;
using System;

namespace Hotel_Management.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "App Name")]
        public string AppName { get; set; }
        [Display(Name = "App Title")]
        public string AppTitle { get; set; }
        [Display(Name = "App URL")]
        public string AppURL { get; set; }
        public string Email { get; set; }
        [Display(Name = "App Address")]
        public string AppAddress { get; set; }
        public int Contact { get; set; }
        [Display(Name = "Currency Symbol")]
        public string CurrencySymbol { get; set; }
        [Display(Name = "Currency Order")]
        public string CurrencyOrder { get; set; }
        [Display(Name = "Date Format")]
        public DateTime DateFormat { get; set; }
        [Display(Name = "USD Rate")]
        public int USDRate { get; set; }
        [Display(Name = "App Logo")]
        public string AppLogo { get; set; }

    }
}
