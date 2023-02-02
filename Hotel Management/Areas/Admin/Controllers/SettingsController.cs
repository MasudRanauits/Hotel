using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Hotel_Management.Areas.Admin.Controllers
{
    public class SettingsController : Controller
    {
        private ApplicationDbContext _db;
        private IWebHostEnvironment _iwebhost;
        public SettingsController(ApplicationDbContext db, IWebHostEnvironment iwebhost)
        {
            _db = db;
            _iwebhost = iwebhost;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Setting settings,IFormFile ifile)
        {
            if (ModelState.IsValid)
            {
                if (ifile!=null)
                {
                    //image save file
                    var name = Path.Combine(_iwebhost.WebRootPath + "/Image", Path.GetFileName(ifile.FileName));
                    await ifile.CopyToAsync(new FileStream(name, FileMode.Create));
                    settings.AppLogo = "Image/" + ifile.FileName;


                    // Database path save
                    settings.AppLogo = name;
                    await _db.Setting.AddAsync(settings);
                    await _db.SaveChangesAsync();
                }


                //string imgext = Path.GetExtension(ifile.FileName);
                //if (imgext==".jpg" || imgext== ".png" || imgext==".gif")
                //{
                //    var saveing = Path.Combine(_iwebhost.WebRootPath, "Image",ifile.FileName);
                //    var stream = new FileStream(saveing, FileMode.Create);
                //    await ifile.CopyToAsync(stream);

                //    settings.AppLogo =saveing;
                //    await _db.Setting.AddAsync(settings);
                //    await _db.SaveChangesAsync();
                //    ViewData["Message"] = "Image Save";
                //}
                //else
                //{
                //    ViewData["Message"] = "Please upload only .jpg , .png & .gif Images";
                //}
                _db.Setting.Add(settings);
                await _db.SaveChangesAsync();
                //return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
                return View();
            }
            return View(settings);
        }
    }
}
