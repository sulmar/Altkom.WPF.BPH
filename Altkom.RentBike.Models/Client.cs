using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.RentBike.Models
{
    public class Client : Base
    {
        public int ClientId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ClientNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string FullNameBis
        {
            get
            {
                return String.Format("{0} {1}", FirstName, LastName);
            }
        }

    }
}
