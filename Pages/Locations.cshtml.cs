using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using MagillStore.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MagillStore.WebSite.Pages
{
    public class LocationsModel : PageModel
    {
        //used to populate the City select list
        public List<SelectListItem> LocationCities { get; private set; }


        //used to populate the Location grid
        public IEnumerable<Location> Locations { get; private set; }


        // OnGet() populates Locations (for the Location displays) and LocationCities (for the Cities filter select list)
        public void OnGet()
        {
            //false for the input parameter means the locations are not filtered by the City Selection
            Locations = ReturnLocations(false);   
            GetLocationCities();
        }


        //BindProperty on the City binds the value to the City Select list
        [BindProperty]
        public string City { get; set; }


        // OnPost calls the GetFilteredlocations (filtered by selected City) when the Filter button is clicked
        public void OnPost()
        {
            //true for the input parameter means the locations are filtered by the City Selection
            Locations = ReturnLocations(true);
            GetLocationCities();
        }



        //Returnlocations() returns IEnumerable<Location> list of all the Locations
        //uses LINQ to XML for form the Location objects, and the list is filtered base on the filteredByCity input parameter
        //input of true means filter the list by city, otherwise no filtering occurs and you get the full list
        private IEnumerable<Location> ReturnLocations(Boolean filteredByCity)
        {
            XDocument doc = XDocument.Load("store_locations.xml");
            IEnumerable<Location> result = from c in doc.Descendants("store")
                                           where ((c.Element("city").Value == City && filteredByCity == true)|| filteredByCity == false)
                                           select new Location()
                                           {
                                               LocationId = c.Element("storeid").Value,
                                               LocationName = c.Element("location").Value,
                                               Address = c.Element("address").Value,
                                               City = c.Element("city").Value,
                                               State = c.Element("state").Value,
                                               Zip = c.Element("zip").Value,
                                               Lat = c.Element("lat").Value,
                                               Lon = c.Element("lon").Value,
                                           };
            return result;
        }



        //GetLocationCities() forms a list of SelectListItems to populate the City Select List 
        private void GetLocationCities()
        {
            //always get the unfiltered Locations so the select list remains the full set
            IEnumerable<Location> unfilteredLocations = ReturnLocations(false);
            List<SelectListItem> result = new List<SelectListItem>();

            SelectListItem defaultItem = new SelectListItem();
            defaultItem.Text = "Please Select";
            result.Add(defaultItem);
            foreach (Location location in unfilteredLocations)
            {
                SelectListItem thisItem = new SelectListItem();
                thisItem.Text = location.City;
                result.Add(thisItem);
            }
            LocationCities = result;

        }
    }
}
