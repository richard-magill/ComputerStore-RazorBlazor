using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MagillStore.WebSite.Models;
using MagillStore.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MagillStore.WebSite.Pages
{
    public class LaptopsModel : PageModel
    {
        private readonly ILogger<LaptopsModel> _logger;


        public IEnumerable<Product> Products { get; private set; }

        //laptops model, sets up the logger
        public LaptopsModel(ILogger<LaptopsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            DatabaseService dbObject = new DatabaseService();
            Products = dbObject.GetProductList();
            Products =
                from product in Products
                where product.Type == "Laptop"
                select product;
        }
    }
}
