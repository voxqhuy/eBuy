using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eBuy.Models
{
    public class ViewModel
    {
        public IEnumerable<SelectListItem> categories { get; set; }
    }
}