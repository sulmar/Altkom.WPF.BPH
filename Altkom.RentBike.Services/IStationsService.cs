using Altkom.RentBike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.RentBike.Services
{
    public interface IStationsService
    {
        IList<Station> GetStations();

        void AddStation(Station station);

        void RemoveStation(Station station);

        Station GetStation(string name);

    }

}
