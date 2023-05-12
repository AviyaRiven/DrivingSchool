using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.dataObjectBL
{
    public class AdressBl
    {
        public string City { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }

        public AdressBl(string city, string neighborhood, string street, int buildingNumber)
        {
            City = city;
            Neighborhood = neighborhood;
            Street = street;
            BuildingNumber = buildingNumber;
        }
    }
}
