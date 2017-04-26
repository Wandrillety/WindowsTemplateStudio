﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;


namespace Microsoft.Templates.UI.Converters
{
    public class ItemAlignmentConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)value > 1 ? HorizontalAlignment.Stretch : HorizontalAlignment.Left;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
