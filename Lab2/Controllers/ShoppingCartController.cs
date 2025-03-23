using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: Promotion
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}