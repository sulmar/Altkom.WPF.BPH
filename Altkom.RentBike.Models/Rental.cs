using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.RentBike.Models
{
    public class Rental : Base
    {
        public int RentalId { get; set; }

        public Bike Bike { get; set; }

        public Client Client { get; set; }

        public Station StartStation { get; set; }

        public Station EndStation { get; set; }

        public DateTime RentalStartDate { get; set; }

        public DateTime? RentalEndDate { get; set; }
    }
}
