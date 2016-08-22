using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.RentBike.Models
{
    public class Location : Base
    {
        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public Location(float longitude, float latitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
    }
}
