using eBuy.Models;
using eBuy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eBuy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var categories = DbUtils.GetCategories();
            return View(categories);
        }

        // INTERACTIONS
        public ActionResult showAllProducts()
        {
            var products = DbUtils.GetAllProducts();
            return PartialView("ProductList", products);
        }

        
    }
}