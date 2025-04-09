using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Domain.Entities;


namespace OnlineShop.BusinessLogic.Interfaces
{
     public interface ICartService
     {
          void AddToCart(Product product, int quantity);
          void RemoveFromCart(int productId);
          IEnumerable<CartProduct> GetCartProducts();
     }
}

