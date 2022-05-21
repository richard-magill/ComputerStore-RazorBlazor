using MagillStore.WebSite.Models;
using MagillStore.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MagillStore.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(DatabaseService dbObject)
        {
            this.ProductService = dbObject;

        }

        public DatabaseService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProductList();
        }
    }

}
