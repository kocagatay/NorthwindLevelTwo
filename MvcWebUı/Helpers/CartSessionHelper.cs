using Entities.DomainModels;
using MvcWebUI.Extensions;

namespace MvcWebUI.Helpers
{
    public class CartSessionHelper : ICartSessionHelper
    {
        IHttpContextAccessor _httpcontextAccessor; //Session controller odaklı olduğu için buna ihtiyacımız oluyor. Session'ı buradan çağırıyoruz.

        public CartSessionHelper(IHttpContextAccessor httpcontextAccessor)
        {
            _httpcontextAccessor = httpcontextAccessor;
        }

        public void Clear()
        {
            _httpcontextAccessor.HttpContext.Session.Clear();
        }

        public Cart GetCart(string key)
        {
            Cart cartToCheck = _httpcontextAccessor.HttpContext.Session.GetObject<Cart>(key); //Şurada
            if (cartToCheck == null)
            {
                SetCart(key, new Cart());
                cartToCheck = _httpcontextAccessor.HttpContext.Session.GetObject<Cart>(key);
            }
            return cartToCheck;
        }

        public void SetCart(string key, Cart cart)
        {
            _httpcontextAccessor.HttpContext.Session.SetObject(key, cart);
        }
    }
}
