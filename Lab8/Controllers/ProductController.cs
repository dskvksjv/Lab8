using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Lab8.Models;

namespace Lab8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { ID = 1, Name = "Mascara", Price = 195, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Lipstick", Price = 215, CreatedDate = DateTime.Now },
                new Product { ID = 3, Name = "Lipgloss", Price = 295, CreatedDate = DateTime.Now },
                new Product { ID = 4, Name = "Concealer", Price = 359, CreatedDate = DateTime.Now },
                new Product { ID = 5, Name = "Blush", Price = 580, CreatedDate = DateTime.Now },
            };

            return View(products);
        }
    }
}
