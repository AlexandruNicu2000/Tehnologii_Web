using System.Collections.Generic;
using TestingOnlineShop.Domain.Entities;

namespace OnlineShop.BusinessLogic.Interfaces
{
     public interface IProductService
     {
          List<DBProductTable> GetAllProducts();
          DBProductTable GetProductById(int id);
          void AddProduct(DBProductTable product);
          void DeleteProduct(int id);
     }
}
