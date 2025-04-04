using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingOnlineShop.Domain.Entities;

namespace TestingOnlineShop.BussinesLogic.DBModel.Seed
{
     public class ShopDBContext: DbContext
     {
          public DbSet<DBProductTable> Products { get; set; }
          public ShopDBContext() : base("name=ShopDatabase") { }

     }
}
