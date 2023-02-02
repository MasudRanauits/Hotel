using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Management.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HotelServiceController : Controller
    {
        private ApplicationDbContext _db;
        public HotelServiceController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.HotelServices.OrderByDescending(m => m.Id).ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HotelService hotelService)
        {
            if (ModelState.IsValid)
            {
                _db.HotelServices.Add(hotelService);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(HotelService aModel)
        {
            if (ModelState.IsValid)
            {
                var bModel = _db.HotelServices.Find(aModel.Id);
                if(bModel != null)
                {
                    bModel.ServiceName = aModel.ServiceName;
                    bModel.PerUnitPrice = aModel.PerUnitPrice;
                    _db.Entry(bModel).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var bModel = _db.HotelServices.Find(id);
            if (bModel != null)
            {
                _db.Entry(bModel).State = EntityState.Deleted;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var bModel = await _db.HotelServices.FindAsync(id);
            return Json(bModel);
        }
    }
}
