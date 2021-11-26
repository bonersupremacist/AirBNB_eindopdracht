using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBNB.Classes
{
    public class Landlords
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AmountOfHouses { get; set; }
        public List<Locations> RentalHouses { get; set; }

        public Landlords()
        {
            RentalHouses = new List<Locations>();
        }

    }
}
