using System;
using System.Globalization;
using System.Windows.Data;

namespace UserManagmentApp.Converters
{
    public class FullNameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length == 2 && values[0] != null && values[1] != null)
            {
                string firstName = values[0].ToString();
                string lastName = values[1].ToString();
                return $"{firstName} {lastName}";
            }
            return string.Empty;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
