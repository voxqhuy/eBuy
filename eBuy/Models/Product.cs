using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBuy.Models
{
    public class Product
    {
        int product_id { get; set; }
        int product_type_id { get; set; }
        String product_name { get; set; }
        String product_description { get; set; }
        Decimal price { get; set; }
        int in_stock { get; set; }
    }
}