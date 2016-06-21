using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace GHMonitor
{
    public class TemperatureColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            float x = (float)value;
            if (x < DataExchangeHelper.TemperatureLowThreshold)
            {
                return new SolidColorBrush(Colors.Yellow);
            }
            else if (x > DataExchangeHelper.TemperatureHighThreshold)
            {
                return new SolidColorBrush(Colors.Red);
            }
            else
            {
                return new SolidColorBrush(Colors.YellowGreen);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
