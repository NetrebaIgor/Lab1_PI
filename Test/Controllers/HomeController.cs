using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {


        private DataContext db;

        public HomeController(DataContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cars()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cars(InsuranceСar car)
        {
            db.Cars.Add(car);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Medics()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Medics(InsuranceMedic medic)
        {
            db.Medic.Add(medic);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        public IActionResult AutoCitizen()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AutoCitizen(InsuranceAutoCitizen auto)
        {
            db.AutoCitizens.Add(auto);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult COVID()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> COVID(InsuranceCOVID covid)
        {
            db.COVID.Add(covid);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
