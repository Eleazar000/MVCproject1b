using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab3.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public String Index()
        {
            return "Product/Index is displayed";
        }
        public String Browse()
        {
            return "Browse displayed";
        }
        public string Details(int id)
        {
            string message = "Details displayed for ID = " + id;
            return message;
        }

        public String Location(string zip)
        {
            string message = HttpUtility.HtmlEncode("Location displayed for zip = " + zip);
            return message;
        }
    }
}