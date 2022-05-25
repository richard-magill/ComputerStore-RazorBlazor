using MagillStore.WebSite.Models;
using MagillStore.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SQLite;


namespace MagillStore.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        //these services were the JSON services, replaced by database calls
        //public JsonFileProductService ProductService;
        //public JsonFileProductCategoryService ProductCategoryService;

        public IEnumerable<ProductCategory> ProductCategories { get; private set; }

        //index model, sets up the page context and logger
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            //this was the original JSON deserializer for product category, replaced by the database call in OnGet()
            //ProductCategoryService = productCategoryService;
        }

        //OnGet pulls in the resources for the cshtml index page
        public void OnGet()
        {

            DatabaseService dbObject = new DatabaseService();
            ProductCategories = dbObject.GetProductCategoryList();


        }

       
        //this was a method to insert things into the SQLite database, not in use
       
    }
}
