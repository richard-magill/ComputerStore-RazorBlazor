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
    public class AccessoriesModel : PageModel
    {
        private readonly ILogger<AccessoriesModel> _logger;

        public IEnumerable<Product> Products { get; private set; }

        //accessories model, sets up the logger
        public AccessoriesModel(ILogger<AccessoriesModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

            DatabaseService dbObject = new DatabaseService();

                Products = dbObject.GetProductList();
                Products =
                    from product in Products
                    where product.Type == "Accessory"
                    select product;

        }
    }
}
