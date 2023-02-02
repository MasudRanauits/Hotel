using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Hotel_Management.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BaseDiscountController : Controller
    {
        //SqlConnection con = new SqlConnection("Server=DESKTOP-7U1HJKJ\\SQLEXPRESS;Database=Hotel-ManagementDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        //SqlCommand con = new SqlCommand();
        //SqlDataReader dr;
        private ApplicationDbContext _db;
        public BaseDiscountController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BaseDiscount baseDiscount)
        {
            //if (ModelState.IsValid)
            //{
            //    _db.BaseDiscounts.Add(baseDiscount);
            //    _db.SaveChanges();
            //    //return RedirectToAction("Create");
            //    return View();
            //}
            _db.BaseDiscounts.Add(baseDiscount);
            _db.SaveChanges();

            return View();
        }
    }
}
