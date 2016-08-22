using Altkom.RentBike.Models;
using Altkom.RentBike.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.RentBike.ViewModels
{
    public class BikesViewModel : BaseViewModel
    {
        public IList<Bike> Bikes { get; set; }

        public Bike SelectedBike { get; set; }

        private IBikesService BikesService = new MockBikesService();

        public BikesViewModel()
        {
            Bikes = BikesService.GetBikes();
        }
    }
}
