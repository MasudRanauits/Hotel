using Hotel_Management.Data;
using Hotel_Management.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Management.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InformationController : Controller
    {
        private readonly ApplicationDbContext repository;

        public InformationController(ApplicationDbContext repository)
        {
            this.repository = repository;
        }
        //get method
        public async Task<ActionResult> Index()
        {
            
            return await Task.Run(() => View(repository.Informations.OrderByDescending(m => m.Id).ToListAsync()));
        }
        
        //get method
        public async Task<ActionResult> Create()
        {
            return await Task.Run(() => View());
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Information information)
        {
            repository.Informations.Add(information);
            await repository.SaveChangesAsync();
            //TempData["message"] = await repository.Create(information);
            return await Task.Run(() => RedirectToRoute("Index"));
        }
    }
}
