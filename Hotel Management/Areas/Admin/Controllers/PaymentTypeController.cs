using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Management.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PaymentTypeController : Controller
    {
        private ApplicationDbContext _db;
        public PaymentTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _db.PaymentTypes.OrderByDescending(m => m.Id).ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaymentType paymentType)
        {
            if (ModelState.IsValid)
            {
                _db.PaymentTypes.Add(paymentType);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PaymentType aModel)
        {
            if (ModelState.IsValid)
            {
                var bModel = _db.PaymentTypes.Find(aModel.Id);
                if (bModel != null)
                {
                    bModel.PaymentTypeTitle = aModel.PaymentTypeTitle;
                    _db.Entry(bModel).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var bModel = _db.PaymentTypes.Find(id);
            if (bModel != null)
            {
                _db.Entry(bModel).State = EntityState.Deleted;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var bModel = await _db.PaymentTypes.FindAsync(id);
            return Json(bModel);
        }
    }
}
