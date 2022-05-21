using MagillStore.WebSite.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MagillStore.WebSite.Services
{
    public class JsonFileProductCategoryService
    {
        public JsonFileProductCategoryService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "productcategory.json"); }
        }

        public IEnumerable<ProductCategory> GetProductCategories()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return System.Text.Json.JsonSerializer.Deserialize<ProductCategory[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

    }
}
