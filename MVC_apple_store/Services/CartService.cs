using DataAccess;
using DataAccess.Entities;
using MVC_Ferrari.Helpers;

namespace MVC_Ferrari.Services
{
    public interface ICartService
    {
        bool IsProductInCart(int id);
        void AddProductToCart(int id);
        void RemoveProductFromCart(int id);
        void ClearCart();
        IEnumerable<Car> GetProductsFromCart();
    }
    public class CartService : ICartService
    {
        private readonly StoreDbContext context;
        private readonly HttpContext httpContext;

        public CartService(StoreDbContext context,
                           IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            this.httpContext = httpContextAccessor.HttpContext;
        }

        public bool IsProductInCart(int id)
        {
            var productIds = httpContext.Session.GetObject<List<int>>(WebConstants.cartListKey);

            if (productIds == null) return false;

            return productIds.Contains(id);
        }

        public void AddProductToCart(int id)
        {
            var productIds = httpContext.Session.GetObject<List<int>>(WebConstants.cartListKey);

            if (productIds == null)
                productIds = new List<int>();

            productIds.Add(id);

            httpContext.Session.SetObject(WebConstants.cartListKey, productIds);
        }
        public void RemoveProductFromCart(int id)
        {
            var productIds = httpContext.Session.GetObject<List<int>>(WebConstants.cartListKey);

            if (productIds == null) return;

            productIds.Remove(id);

            httpContext.Session.SetObject(WebConstants.cartListKey, productIds);
        }
        public void ClearCart()
        {
            var productIds = httpContext.Session.GetObject<List<int>>(WebConstants.cartListKey);

            if (productIds == null) return;

            productIds.Clear();

            httpContext.Session.SetObject(WebConstants.cartListKey, productIds);
        }
        public IEnumerable<Car> GetProductsFromCart()
        {
            var productIds = httpContext.Session.GetObject<List<int>>(WebConstants.cartListKey);

            if (productIds == null) return new List<Car>();

            List<Car> cars = productIds.Select(id => context.Cars.Find(id)).ToList();

            return cars;
        }
    }
}
