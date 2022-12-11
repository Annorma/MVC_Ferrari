using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using MVC_Ferrari.Helpers;
using MVC_Ferrari.Services;

namespace MVC_Ferrari.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly StoreDbContext context;

        public CartController(ICartService cartService, StoreDbContext context)
        {
            this.cartService = cartService;
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = cartService.GetProductsFromCart();

            return View(products);
        }

        public IActionResult Add(int productId)
        {
            if (productId < 0) return BadRequest();

            var car = context.Cars.Find(productId);

            if (car == null) return NotFound();

            cartService.AddProductToCart(productId);

            TempData[WebConstants.alertMsgKey] = "Model was added to cart!";

            return RedirectToAction("Details", "Cars", new { id = productId });
        }
        public IActionResult Remove(int productId)
        {
            if (productId < 0) return BadRequest();

            var car = context.Cars.Find(productId);

            if (car == null) return NotFound();

            cartService.RemoveProductFromCart(productId);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Clear()
        {
            cartService.ClearCart();

            return RedirectToAction(nameof(Index));
        }
    }
}
