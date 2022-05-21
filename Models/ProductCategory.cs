using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MagillStore.WebSite.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }

        public string ImageUrl { get; set; }
        public string Page { get; set; }


        public override string ToString() => JsonSerializer.Serialize<ProductCategory>(this);

       
    }
}
