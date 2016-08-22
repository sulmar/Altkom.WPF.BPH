using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.RentBike.Models;

namespace Altkom.RentBike.Services
{
    public class MockBikesService : IBikesService
    {
        private readonly IList<Bike> _Bikes;

        public MockBikesService()
        {
            _Bikes = new List<Bike>
            {
                new Bike { BikeId = 1, Color = "Blue", Model = "Wigry 3" , Number = "R001" },
                new Bike { BikeId = 2, Color = "Red", Model = "Passat" , Number = "R002" },
                new Bike { BikeId = 3, Color = "Blue", Model = "Jubilat" , Number = "R003" },
            };
        }

        public IList<Bike> GetBikes()
        {
            return _Bikes;
        }
    }
}
