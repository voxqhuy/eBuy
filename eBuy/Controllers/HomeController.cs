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
            var viewModel = new ViewModel
            {
                categories = GetCategories()
            };
            return View(viewModel);
        }

        // INTERACTIONS
        public ActionResult ShowAllProducts()
        {
            var products = DbUtils.GetAllProducts();
            return PartialView("ProductList", products);
        }

        public ActionResult Search(String text, string categoryId)
        {
            var products = DbUtils.SearchBy(text, categoryId);
            return PartialView("ProductList", products);
        }

        public ActionResult RefreshCart()
        {
            
            return PartialView("CartView");
        }

        // Helper methods
        private IEnumerable<SelectListItem> GetCategories()
        {
            var allCategories = DbUtils.GetCategories().Select(x =>
                                new SelectListItem
                                {
                                    Value = x.product_type_id.ToString(),
                                    Text = x.type_name
                                });

            return new SelectList(allCategories, "Value", "Text");
        }
    }
}