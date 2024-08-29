using System;
using System.Globalization;
using System.Windows.Data;


namespace The_Movies.Converter
{
    public class TimeOnlyToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TimeOnly timeOnly)
            {
                return timeOnly.ToString("HH:mm"); // Format: 24-timers format
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string timeString && TimeOnly.TryParse(timeString, out var timeOnly))
            {
                return timeOnly;
            }
            return default(TimeOnly);
        }
    }
}
