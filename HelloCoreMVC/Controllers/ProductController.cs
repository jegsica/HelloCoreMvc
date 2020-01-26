using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloCoreMVC.Models;

namespace HelloCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product p = new Product();
            p.ProductId = "001";
            p.ProductName = "ASP.NET Core MVC";
            p.ProductPrice = 299;
            return View(p);
        }

        public IActionResult Product()
        {
            Product p = new Product();
            p.ProductId = "001";
            p.ProductName = "ASP.NET Core MVC";
            p.ProductPrice = 299;
            return View(p);
        }

    }
}