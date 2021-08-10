using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using System;

namespace Categoryio.Destkop.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var boolean = (bool)value;

            if (parameter is not null)
            {
                boolean = !boolean;
            }

            return boolean ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
