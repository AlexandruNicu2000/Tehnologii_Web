﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Entities
{
     public class Product
     {
          public int Id { get; set; }
          public string Name { get; set; }
          public decimal Price { get; set; }
          public string ImageUrl { get; set; }
          public string Category { get; set; }
     }
}

