using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Management.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuestTypeDiscountController : Controller
    {
        private ApplicationDbContext _db;
        public GuestTypeDiscountController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["guestTypeId"] = new SelectList(_db.GuestTypes.ToList(), "Id", "GuestTypesTitle");
            return View(await _db.guestTypeDiscounts.Include(c => c.GuestType).OrderByDescending(m => m.Id).ToListAsync());
        }
        public IActionResult Create()
        {
            
            return View();
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GuestTypeDiscount guestTypeDiscount)
        {
            if (ModelState.IsValid)
            {
                _db.guestTypeDiscounts.Add(guestTypeDiscount);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GuestTypeDiscount aModel)
        {
            if (ModelState.IsValid)
            {
                var bModel = _db.guestTypeDiscounts.Find(aModel.Id);
                if (bModel != null)
                {
                    bModel.Discount = aModel.Discount;
                    bModel.GuestTypeId = aModel.GuestTypeId;
                    _db.Entry(bModel).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var bModel = _db.guestTypeDiscounts.Find(id);
            if (bModel != null)
            {
                _db.Entry(bModel).State = EntityState.Deleted;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var bModel = await _db.guestTypeDiscounts.FindAsync(id);
            return Json(bModel);
        }
    }
}
