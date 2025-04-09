using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities
{
     public class CartProduct
     {
          public Product Product { get; set; }
          public int Quantity { get; set; }
          public decimal TotalPrice => Product.Price * Quantity;
     }
}
