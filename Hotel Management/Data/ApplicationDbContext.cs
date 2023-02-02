using Hotel_Management.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Data
{
    public class ApplicationDbContext : /*Identity*/DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<AddHotels> AddHotels { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<BaseDiscount> BaseDiscounts { get; set; }
        public DbSet<HotelService> HotelServices { get; set; }
        public DbSet<GuestType> GuestTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<GuestTypeDiscount> guestTypeDiscounts { get; set; }
        public DbSet<PaymentTypeDiscount> paymentTypeDiscounts { get; set; }
        public DbSet<Information> Informations { get; set; }

        internal Task<object> Create(Information information)
        {
            throw new NotImplementedException();
        }
    }
}