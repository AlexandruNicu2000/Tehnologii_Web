using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Domain.Entities;

namespace WebApplication4.BusinessLogic.Interfaces
{
    
}
public interface IProductService
{
    Task<bool> AddProductAsync(Product product); 
    Task<bool> UpdateProductAsync(Product product); 
    Task<bool> DeleteProductAsync(int productId); 
    Task<Product> GetProductByIdAsync(int productId); 
    Task<List<Product>> GetAllProductsAsync(); 
}


