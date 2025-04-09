using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.BusinessLogic.Interfaces;
using OnlineShop.Domain.Entities;

namespace OnlineShop.Web.Controllers
{
     public class CartController : Controller
     {
          private readonly ICartService _cartService;

          public CartController(ICartService cartService)
          {
               _cartService = cartService;
          }

          public IActionResult Cart()
          {
               var cartProducts = _cartService.GetCartProducts();
               return View(cartProducts);
          }

          [HttpPost]
          public IActionResult AddToCart(int productId, int quantity)
          {
               var product = new Product
               {
                    Id = productId,
                    Name = "Example Product",
                    Price = 100.00m,
                    ImageUrl = "/images/example.jpg",
                    Category = "Example Category"
               };

               _cartService.AddToCart(product, quantity);
               return RedirectToAction("Cart");
          }

          [HttpPost]
          public IActionResult RemoveFromCart(int productId)
          {
               _cartService.RemoveFromCart(productId);
               return RedirectToAction("Cart");
          }
     }
}


