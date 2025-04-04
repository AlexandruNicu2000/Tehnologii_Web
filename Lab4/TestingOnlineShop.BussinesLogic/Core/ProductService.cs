using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingOnlineShop.BussinesLogic.DBModel.Seed;
using TestingOnlineShop.Domain.Entities;

namespace TestingOnlineShop.BussinesLogic.Core
{
          public class ProductService
          {
               private readonly ShopDBContext _context;

               public ProductService()
               {
                    _context = new ShopDBContext();
               }

               public List<DBProductTable> GetAllProducts()
               {
                    return _context.Products.ToList();
               }

               public DBProductTable GetProductById(int id)
               {
                    return _context.Products.Find(id);
               }

               public void AddProduct(DBProductTable product)
               {
                    _context.Products.Add(product);
                    _context.SaveChanges();
               }

               public void DeleteProduct(int id)
               {
                    var product = _context.Products.Find(id);
                    if (product != null)
                    {
                         _context.Products.Remove(product);
                         _context.SaveChanges();
                    }
               }
          }
     }
