using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingOnlineShop.BussinesLogic.Core;

namespace TestingOnlineShop.Web.Controllers
{
    public class HomeController : Controller
    {
          private readonly ProductService _productService;
          public HomeController()
          {
               _productService = new ProductService();
          }
          public ActionResult Home()
          {
               var products = _productService.GetAllProducts();
               return View(products);
          }

     }
}