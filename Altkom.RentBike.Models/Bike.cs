using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Altkom.RentBike.Models
{
    public class Bike : Base
    {
        public int BikeId { get; set; }

        public string Color { get; set; }

        public string Model { get; set; }

        public string Number { get; set; }

        public Station Station { get; set; }

        public Location Location { get; set; }

       
    }
}
