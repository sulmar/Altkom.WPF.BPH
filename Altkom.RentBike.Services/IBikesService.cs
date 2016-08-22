using Altkom.RentBike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.RentBike.Services
{
    public interface IBikesService
    {
        IList<Bike> GetBikes();
    }
}
