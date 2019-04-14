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
            var products = DbUtils.GetAllProducts();
            // TODO: send products to view and generate all
            return View();
        }

        
    }
}