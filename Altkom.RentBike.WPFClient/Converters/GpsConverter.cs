using Altkom.RentBike.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;

namespace Altkom.RentBike.WPFClient.Converters
{
    public class GpsConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Location location = value as Location;

            if (location == null)
                return null;

            var locationStr = String.Format(CultureInfo.InvariantCulture, "({0}, {1})", location.Longitude,location.Latitude);

            return locationStr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
