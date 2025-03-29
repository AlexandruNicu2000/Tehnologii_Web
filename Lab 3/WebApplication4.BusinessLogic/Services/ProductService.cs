using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Domain.Entities;
using WebApplication4.BusinessLogic.Interfaces;

namespace WebApplication4.BusinessLogic.Services
{
    public class ProductService : IProductService
    {
        private static List<Product> _products = new List<Product>();

        public async Task<bool> AddProductAsync(Product product)
        {
            _products.Add(product);
            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateProductAsync(Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.ProductId == product.ProductId);

            if (existingProduct == null)
            {
                return await Task.FromResult(false);
            }

            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.Category = product.Category;
            existingProduct.Stock = product.Stock;

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
            {
                return await Task.FromResult(false);
            }

            _products.Remove(product);
            return await Task.FromResult(true);
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var product = _products.FirstOrDefault(p => p.ProductId == productId);
            return await Task.FromResult(product);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await Task.FromResult(_products);
        }
    }
}
