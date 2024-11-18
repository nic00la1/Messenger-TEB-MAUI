using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace Messenger_TEB_MAUI.Converters
{
    public class BoolToHorizontalOptionsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isSentByUser)
            {
                return isSentByUser ? LayoutOptions.End : LayoutOptions.Start;
            }
            return LayoutOptions.Start;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
