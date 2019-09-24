using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ProcentAppXamarin.Converters
{

    public static class test
    {
        public static double Get(double a)
        {
            return Convert.ToDouble(a);
        }
    }

    public class NullValueToVisibilityConverterDouble : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {                                
            if (test.Get((double)value) == 0)
                return null;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
