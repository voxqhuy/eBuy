using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBuy.Models
{
    public class CartViewModel
    {
        public List<Product> products { get; set; }
        public decimal total { get; set; }
    }
}