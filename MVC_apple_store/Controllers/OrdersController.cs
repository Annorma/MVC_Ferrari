using DataAccess;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using MVC_Ferrari.Services;
using Microsoft.AspNetCore.Identity;

namespace MVC_Ferrari.Controllers
{
    public class OrdersController : Controller
    {
        private readonly StoreDbContext context;
        private readonly ICartService cartService;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public OrdersController(StoreDbContext context,
                                ICartService cartService,
                                UserManager<User> userManager,
                                SignInManager<User> signInManager)
        {
            this.context = context;
            this.cartService = cartService;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task<IActionResult> Index()
        {
            if (!HttpContext.User.Identity.IsAuthenticated) return BadRequest();

            var user = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            var orders = context.Orders.Where(o => o.ClientId == user.Id).ToList();

            return View(orders);
        }

        public async Task<IActionResult> Add()
        {
            var products = cartService.GetProductsFromCart().ToList();
            cartService.ClearCart();

            if (HttpContext.User.Identity == null) return BadRequest();

            var user = await userManager.FindByNameAsync(HttpContext.User.Identity.Name);

            Order newOrder = new Order()
            {
                Date = DateTime.Now,
                Products = products,
                TotalPrice = products.Sum(c => c.Price),
                ClientId = user.Id
            };

            context.Orders.Add(newOrder);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
