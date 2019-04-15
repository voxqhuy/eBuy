using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eBuy.Models
{
    public class ProductType
    {
        public int product_type_id { get; set; }
        [Display(Name="Category")]
        public string type_name { get; set; }

    }
}