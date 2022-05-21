using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace MagillStore.WebSite.Models
{
    public class Location
	{
		public string LocationId { get; set; }
		public string LocationName { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Lat { get; set; }
		public string Lon { get; set; }

		public Location() { }

	}
}
