using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShop.Domain.Enums;
using TestingOnlineShop.BussinesLogic.Core;
using TestingOnlineShop.Domain.Entities;

public class AdminController : Controller
{
     private readonly ProductService _productService;

     public AdminController()
     {
          _productService = new ProductService();
     }

     public ActionResult Admin()
     {
          var products = _productService.GetAllProducts();
          ViewBag.Categories = Enum.GetValues(typeof(ProductCategory));
          ViewBag.Brand = Enum.GetValues(typeof(ProductBrand));
          ViewBag.Country = Enum.GetValues(typeof(ProductCountry));
          ViewBag.SpecialCategory = Enum.GetValues(typeof(ProductSpecialCategory));
          return View(products);
     }

     [HttpPost]
     public ActionResult AddProduct(DBProductTable product, HttpPostedFileBase ImageFile)
     {
          if (ImageFile != null && ImageFile.ContentLength > 0)
          {
               string fileName = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(ImageFile.FileName);
               string path = System.IO.Path.Combine(Server.MapPath("~/Content/images/"), fileName);
               ImageFile.SaveAs(path);
               product.ImageUrl = "/Content/images/" + fileName;
          }

          _productService.AddProduct(product);
          return RedirectToAction("Admin");
     }

     [HttpPost]
     public ActionResult DeleteProduct(int id)
     {
          _productService.DeleteProduct(id);
          return RedirectToAction("Admin");
     }
}