using System;
using System.Globalization;
using System.Windows.Data;

namespace UserManagmentApp.Converters
{
    public class MultiValueConverterExample : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            // Aquí podrías combinar los valores recibidos de acuerdo a tu lógica
            return $"{values[0]} - {values[1]}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
