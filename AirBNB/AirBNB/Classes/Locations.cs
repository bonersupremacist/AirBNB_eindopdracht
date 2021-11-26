using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBNB.Classes
{
    public class Locations
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public string Zipcode { get; set; }
        public int NumberofRooms { get; set; }
        public int NumberofBathrooms { get; set; }
        public bool Reserved { get; set; }

        public int Price_Euro { get; set; }
    }

    public class MakeListOfLocations
    {
        List<MakeListOfLocations> listOfLocations = new List<MakeListOfLocations>();
    }
}
