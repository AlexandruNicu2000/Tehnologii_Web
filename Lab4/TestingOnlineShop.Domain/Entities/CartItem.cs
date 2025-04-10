﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingOnlineShop.Domain.Entities
{
     public class CartItem
     {
          public int Id { get; set; }
          public DBProductTable Product { get; set; }
          public int Quantity { get; set; }
          public decimal FinalPrice => Product.Price * Quantity;
     }

}
