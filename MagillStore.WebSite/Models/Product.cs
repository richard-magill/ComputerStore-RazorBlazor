using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MagillStore.WebSite.Models
{
    public class Product
    {


        public string Name{ get; set; }


        public string Description { get; set; }

        public string Brand { get; set; }


        public int Price { get; set; }


        public string Type { get; set; }
 
    }
}
