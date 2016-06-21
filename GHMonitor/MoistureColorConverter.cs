using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace GHMonitor
{
    public class MoistureColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            float x = (float)value;
            if (x < DataExchangeHelper.MoistureLowThreshold)
            {
                return new SolidColorBrush(Colors.Yellow);
            }
            else if(x > DataExchangeHelper.MoistureHighThreshold)
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
