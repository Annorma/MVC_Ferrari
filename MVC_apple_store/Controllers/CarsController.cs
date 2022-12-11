using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Ferrari.Helpers;
using MVC_Ferrari.Models;
using MVC_Ferrari.Services;

namespace MVC_Ferrari.Controllers
{
    public class CarsController : Controller
    {
        private readonly StoreDbContext context;
        private readonly ICartService cartService;

        public CarsController(StoreDbContext context, ICartService cartService)
        {
            this.context = context;
            this.cartService = cartService;
        }

        // GET: /Cars/Index or /Cars
        public IActionResult Index()
        {
            var cars = context.Cars.Include(c => c.Color).ToList(); //MockData.GetCars();

            return View(cars);
        }

        // GET: /Cars/Manage
        public IActionResult Manage()
        {
            var cars = context.Cars.Include(c => c.Color).ToList();

            return View(cars); // ~Views/Cars/Manage.cshtml
        }

        // GET: /Cars/Details/{id}
        public IActionResult Details(int id)
        {
            if (id < 0) return BadRequest();

            var car = context.Cars.Find(id); //MockData.GetCars().FirstOrDefault(p => p.Id == id);

            if (car == null) return NotFound();

            ViewBag.ReturnUrl = Request.Headers["Referer"].ToString();
            ViewBag.IsInCart = cartService.IsProductInCart(id);

            return View(car);
        }
        
        // GET: /Cars/Create
        public IActionResult Create()
        {
            var colors = new SelectList(context.Colors, nameof(Color.Id), nameof(Color.Name));

            // ViewData - type Conversion code is required while enumerating
            // ViewData["ColorList"] = colors;

            // ViewBag - used dynamic, so there is no need to type conversion while enumerating
            ViewBag.ColorList = colors;

            return View();
        }

        // POST: /Cars/Create
        [HttpPost]
        public IActionResult Create(Car car)
        {
            if (!ModelState.IsValid)
            {
                var colors = new SelectList(context.Colors, nameof(Color.Id), nameof(Color.Name));
                ViewBag.ColorList = colors;
                return View(car);
            }

            context.Cars.Add(car);
            context.SaveChanges();

            TempData[WebConstants.alertMsgKey] = "New model was added successfully!";

            return RedirectToAction(nameof(Manage));
        }

        // GET: /Phones/Edit/{id}
        public IActionResult Edit(int id)
        {
            if (id < 0) return BadRequest();

            var car = context.Cars.Find(id);

            if (car == null) return NotFound();

            var colors = new SelectList(context.Colors, nameof(Color.Id), nameof(Color.Name));
            ViewBag.ColorList = colors;

            return View(car);
        }

        // POST: /Cars/Edit
        [HttpPost]
        public IActionResult Edit(Car car)
        {
            if (!ModelState.IsValid)
            {
                var colors = new SelectList(context.Colors, nameof(Color.Id), nameof(Color.Name));
                ViewBag.ColorList = colors;
                return View(car);
            }

            context.Cars.Update(car);
            context.SaveChanges();

            TempData[WebConstants.alertMsgKey] = "Model was edited successfully!";

            return RedirectToAction(nameof(Manage));
        }

        // GET: /Cars/Delete/{id}
        public IActionResult Delete(int id)
        {
            if (id < 0) return BadRequest();

            var car = context.Cars.Find(id);

            if (car == null) return NotFound();

            context.Cars.Remove(car);
            context.SaveChanges();

            TempData[WebConstants.alertMsgKey] = "Model was deleted successfully!";

            return RedirectToAction(nameof(Manage));
        }
    }
}
