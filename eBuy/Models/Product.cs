using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBuy.Models
{
    public class Product
    {
        public int product_id { get; set; }
        public int product_type_id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public string price { get; set; }
        public int in_stock { get; set; }
    }
}