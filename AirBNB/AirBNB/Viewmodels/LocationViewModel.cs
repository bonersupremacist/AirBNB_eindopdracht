using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirBNB.Classes;
using AirBNB.Viewmodels;

namespace AirBNB.Viewmodels
{
    public class LocationViewModel
    {
        public void make_locations()
        {

            Locations location_one = new Locations();
            location_one.Country = "Netherlands";
            location_one.City = "Amsterdam";
            location_one.StreetName = "Kaasplankje";
            location_one.HouseNumber = 12;
            location_one.Zipcode = "1102AL";
            location_one.Reserved = false;
            location_one.NumberofBathrooms = 3;
            location_one.NumberofRooms = 5;
            location_one.Price_Euro = 133;

            Locations location_two = new Locations();
            location_two.Country = "Netherlands";
            location_two.City = "Groningen";
            location_two.StreetName = "jedenbeen";
            location_two.HouseNumber = 2;
            location_two.Zipcode = "1111AL";
            location_two.Reserved = false;
            location_two.NumberofBathrooms = 1;
            location_two.NumberofRooms = 2;
            location_two.Price_Euro = 90;

            Locations location_three = new Locations();
            location_three.Country = "England";
            location_three.City = "Birmingham";
            location_three.StreetName = "Fishandchips";
            location_three.HouseNumber = 6;
            location_three.Zipcode = "18394P";
            location_three.Reserved = true;
            location_three.NumberofBathrooms = 1;
            location_three.NumberofRooms = 1;
            location_three.Price_Euro = 50;

        }
    }
}
