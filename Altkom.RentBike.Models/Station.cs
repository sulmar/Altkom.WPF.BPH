using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.RentBike.Models
{
    public class Station : Base
    {
        public int StationId { get; set; }

        public string Address { get; set; }

        #region Number

        private string _Number;

        public string Number
        {
            get { return _Number; }
            set
            {
                _Number = value;

                OnPropertyChanged();

                // C# 6.0
                OnPropertyChanged(nameof(FullName));

                // C# 4.0
                OnPropertyChanged(() => FullName2);
            }
        }

        #endregion

        public String FullName
        {
            get
            {
                return String.Format("{0} - {1}", Number, Name);
            }
        }

        // C# 6.0
        public string FullName2 => $"{Number} {Name}";


        public string Name { get; set; }

        public short Capacity { get; set; }

        public byte[] Photo { get; set; }

        public Location Location { get; set; }
    }
}
