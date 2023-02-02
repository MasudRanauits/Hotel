using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Management.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuestTypeController : Controller
    {
        private ApplicationDbContext _db;
        public GuestTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.GuestTypes.OrderByDescending(m => m.Id).ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GuestType guestType)
        {
            if (ModelState.IsValid)
            {
                _db.GuestTypes.Add(guestType);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GuestType aModel)
        {
            if (ModelState.IsValid)
            {
                var bModel = _db.GuestTypes.Find(aModel.Id);
                if (bModel != null)
                {
                    bModel.GuestTypesTitle = aModel.GuestTypesTitle;
                    //bModel.PerUnitPrice = aModel.PerUnitPrice;
                    _db.Entry(bModel).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var bModel = _db.GuestTypes.Find(id);
            if (bModel != null)
            {
                _db.Entry(bModel).State = EntityState.Deleted;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var bModel = await _db.GuestTypes.FindAsync(id);
            return Json(bModel);
        }
    }
}
