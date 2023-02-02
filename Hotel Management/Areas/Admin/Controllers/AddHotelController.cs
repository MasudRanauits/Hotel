using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Management.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AddHotelController : Controller
    {
        private ApplicationDbContext _db;
        public AddHotelController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.AddHotels.ToList());
        }
        //get method
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //post method
        [HttpPost]
        public async Task<IActionResult> Create(int Id,[Bind("Id,HotelName,Address,Location,ContactNo,FaxNumber,EmailAddress,VatRegNo,AreaCode,RestaurantName,Capacity,SSLStoreId,SSLPassword,Description")]AddHotels addHotels)
        {
            if (ModelState.IsValid)
            {
                _db.AddHotels.Add(addHotels);
                await _db.SaveChangesAsync();
                //return RedirectToAction("Index");
                return RedirectToAction(nameof(Index));
            }
            return View(addHotels);
        }


    }
}
