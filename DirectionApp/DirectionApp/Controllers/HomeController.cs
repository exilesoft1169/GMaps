using DirectionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DirectionApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.data = GetListOfLocations();
            return View();
        }
        //public ActionResult Index(Navigate location)
        //{
        //    ViewBag.data = GetListOfLocations();
        //    string returnval = "";
        //    returnval = "from: " + location.From + " to: " + location.To;
        //    return View();
        //}
        private List<Location> GetListOfLocations()
        {
            List<Location> ListOfLocation = new List<Location>();
            Location LocationObj = new Location { LocationId = 1, LocationName = "Colombo", Position = "6.9271,79.8612" };
            ListOfLocation.Add(LocationObj);
            Location LocationObj2 = new Location { LocationId = 2, LocationName = "Godagama", Position = "6.8475,80.0277" };
            ListOfLocation.Add(LocationObj2);
            Location LocationObj3 = new Location { LocationId = 3, LocationName = "Kandy", Position = "7.2906,80.6337" };
            ListOfLocation.Add(LocationObj3);
            Location LocationObj4 = new Location { LocationId = 4, LocationName = "Maharagama", Position = "6.8522,79.9249" };
            ListOfLocation.Add(LocationObj4);
            return ListOfLocation;

        }
    }
}