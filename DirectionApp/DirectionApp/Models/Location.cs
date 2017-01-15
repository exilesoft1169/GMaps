using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DirectionApp.Models
{
    public class Location
    {
        public int LocationId{ get; set; }
        public string LocationName { get; set; }
       // Latitude/Longitude
        public string Position { get; set; }
    }
}