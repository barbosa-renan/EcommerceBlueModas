using Ecommerce.Data;
using Ecommerce.Domain;
using Ecommerce.UI.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Ecommerce.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDBContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDBContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            var products = _context.Product.ToList();

            if (products.Count == 0)
                PopulateDatabaseToTest();

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Create a list of products and insert it in the database for testing.
        /// </summary>
        private void PopulateDatabaseToTest()
        {
            var products = new List<Product> {
                new Product
                {
                    Name = "Camisa Básica",
                    ImagePath = "products/shirts/01.jpg",
                    UnitPrice = 29.90m
               },
               new Product
                {
                    Name = "Camisa Polo Madri",
                    ImagePath = "products/shirts/02.jpg",
                    UnitPrice = 35.00m
               },
               new Product
                {
                    Name = "Camisa Social Slim Fit",
                    ImagePath = "products/shirts/03.jpg",
                    UnitPrice = 59.00m
               },
               new Product
                {
                    Name = "Camisa Social Feminina",
                    ImagePath = "products/shirts/04.jpg",
                    UnitPrice = 39.90m
               },
               new Product
                {
                    Name = "Calça Jeans Masculina",
                    ImagePath = "products/pants/01.jpg",
                    UnitPrice = 110.50m
               },
               new Product
                {
                    Name = "Calça Jeans Feminina",
                    ImagePath = "products/pants/02.jpg",
                    UnitPrice = 139.90m
               },
               new Product
                {
                    Name = "Calça Social Feminina",
                    ImagePath = "products/pants/03.jpg",
                    UnitPrice = 74.00m
               },
               new Product
                {
                    Name = "Calça Social Masculina",
                    ImagePath = "products/pants/04.jpg",
                    UnitPrice = 74.00m
               }
            };

            _context.AddRange(products);
            _context.SaveChanges();
        }
    }
}
