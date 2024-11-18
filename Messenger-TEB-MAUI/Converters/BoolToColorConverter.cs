using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace Messenger_TEB_MAUI.Converters
{
    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isSentByUser)
            {
                return isSentByUser ? "#168AFF" : "#9F33FF";
            }
            return "#9F33FF";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
