using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.RentBike.Models;
using System.IO;

namespace Altkom.RentBike.Services
{
    public class MockStationsService : IStationsService
    {
        private IList<Station> _stations;

        public MockStationsService()
        {
            this._stations = new List<Station>
            {
                new Station
                {
                    StationId = 1,
                    Number = "ST001",
                    Name = "Stacja 1",
                    Address = "Jagiellońska",
                    Capacity = 10,
                    Location = new Location(18.05f, 54.01f),
                 
               },

                new Station
                {
                    StationId = 2,
                    Number = "ST002",
                    Name = "Stacja 2",
                    Address = "Kołobrzeska",
                    Capacity = 20,
                    Location = new Location(18.25f, 54.51f),
                },

                new Station
                {
                    StationId = 3,
                    Number = "ST003",
                    Name = "Stacja 3",
                    Address = "Aleja Zwycięstwa",
                    Capacity = 40,
                    Location = new Location(18.15f, 54.21f),
                },
            };
        }

        public void AddStation(Station station)
        {
            _stations.Add(station);
        }

        public Station GetStation(string name)
        {
            var station = _stations.FirstOrDefault(s => s.Name == name);

            return station;
        }

        public IList<Station> GetStations()
        {
            return _stations;
        }

        public void RemoveStation(Station station)
        {
            _stations.Remove(station);
        }
    }
}
