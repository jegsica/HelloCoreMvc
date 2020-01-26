using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HelloCoreMVC.Models;

namespace HelloCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // [Route("api/index")]
        public IActionResult Index()
        {
            ViewBag.AllCustomer = GetAllCustomer();
            ViewBag.AllProduct = GetAllProduct();
            return View();
        }

        public IActionResult ByViewModel()
        {
            ViewDataModel data = new ViewDataModel();
            data.GetCustomers = GetAllCustomer();
            data.GetProducts = GetAllProduct();
            return View(data);
        }

        public IActionResult ByViewData()
        {
            ViewData["AllCustomer"] = GetAllCustomer();
            ViewData["AllProduct"] = GetAllProduct();
            return View();
        }
        public List<Customer> GetAllCustomer()
        {
            List<Customer> CustomerList = new List<Customer>();
            CustomerList.Add(new Customer { CustomerID = "0001", FullName = "Test1 Test1", Address = "17/21 Modiz Ratchada32" });
            CustomerList.Add(new Customer { CustomerID = "0002", FullName = "Test1 Test2", Address = "18/21 Modiz Ratchada32" });
            CustomerList.Add(new Customer { CustomerID = "0003", FullName = "Test1 Test3", Address = "19/21 Modiz Ratchada32" });
            CustomerList.Add(new Customer { CustomerID = "0004", FullName = "Test1 Test4", Address = "20/21 Modiz Ratchada32" });
            return CustomerList;
        }

        public List<Product> GetAllProduct()
        {
            List<Product> ProductList = new List<Product>();
            ProductList.Add(new Product { ProductId = "001", ProductName = "AAA", ProductPrice = 100 });
            ProductList.Add(new Product { ProductId = "002", ProductName = "BBB", ProductPrice = 200 });
            ProductList.Add(new Product { ProductId = "003", ProductName = "CCC", ProductPrice = 300 });
            ProductList.Add(new Product { ProductId = "004", ProductName = "DDD", ProductPrice = 400 });
            return ProductList;
        }
        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
