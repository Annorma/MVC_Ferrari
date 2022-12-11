using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Ferrari.Models;
using System.Diagnostics;

namespace MVC_Ferrari.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreDbContext context;

        public HomeController(StoreDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var cars = context.Cars.Include(c => c.Color).ToList();
            return View(cars);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}