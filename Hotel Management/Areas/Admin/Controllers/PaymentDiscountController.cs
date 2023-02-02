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
    public class PaymentDiscountController : Controller
    {
        private ApplicationDbContext _db;
        public PaymentDiscountController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            ViewData["paymentTypeId"] = new SelectList(_db.PaymentTypes.ToList(), "Id", "PaymentTypeTitle");
            return View(await _db.paymentTypeDiscounts.Include(c => c.PaymentType).OrderByDescending(m => m.Id).ToListAsync());
        }
        public IActionResult Create()
        {

            return View();
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PaymentTypeDiscount paymentTypeDiscount)
        {
            if (ModelState.IsValid)
            {
                _db.paymentTypeDiscounts.Add(paymentTypeDiscount);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PaymentTypeDiscount aModel)
        {
            if (ModelState.IsValid)
            {
                var bModel = _db.paymentTypeDiscounts.Find(aModel.Id);
                if (bModel != null)
                {
                    bModel.Discount = aModel.Discount;
                    bModel.PaymentTypeId = aModel.PaymentTypeId; //Note
                    _db.Entry(bModel).State = EntityState.Modified;
                    await _db.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var bModel = _db.paymentTypeDiscounts.Find(id);
            if (bModel != null)
            {
                _db.Entry(bModel).State = EntityState.Deleted;
                await _db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var bModel = await _db.paymentTypeDiscounts.FindAsync(id);
            return Json(bModel);
        }
    }
}
