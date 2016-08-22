using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Altkom.RentBike.Services;
using System.Linq;

namespace Altkom.RentBike.UnitTests
{
    [TestClass]
    public class StationsUnitTest
    {
        [TestMethod]
        public void GetStationsTest()
        {
            IStationsService stationsService = new MockStationsService();

            var stations = stationsService.GetStations();

            Assert.IsNotNull(stations);

            Assert.IsTrue(stations.Any());

        }

        [TestMethod]
        public void GetStationByNameTest()
        {
            var stationName = "Stacja 1";

            IStationsService stationsService = new MockStationsService();

            var station = stationsService.GetStation("Stacja 999");

            Assert.IsNull(station);

            station = stationsService.GetStation(stationName);

            Assert.IsNotNull(station);

            Assert.AreEqual(stationName, station.Name);

        }
    }
}
