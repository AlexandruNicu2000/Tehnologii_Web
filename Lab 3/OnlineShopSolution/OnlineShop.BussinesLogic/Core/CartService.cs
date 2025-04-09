using OnlineShop.BusinessLogic.Interfaces;
using OnlineShop.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.BusinessLogic.Core
{
     public class CartService : ICartService
     {
          private readonly List<CartProduct> _cartProducts = new List<CartProduct>();

          public void AddToCart(Product product, int quantity)
          {
               var existingItem = _cartProducts.FirstOrDefault(c => c.Product.Id == product.Id);
               if (existingItem != null)
               {
                    existingItem.Quantity += quantity;
               }
               else
               {
                    _cartProducts.Add(new CartProduct { Product = product, Quantity = quantity });
               }
          }

          public void RemoveFromCart(int productId)
          {
               _cartProducts.RemoveAll(c => c.Product.Id == productId);
          }

          public IEnumerable<CartProduct> GetCartProducts()
          {
               return _cartProducts;
          }
     }
}

