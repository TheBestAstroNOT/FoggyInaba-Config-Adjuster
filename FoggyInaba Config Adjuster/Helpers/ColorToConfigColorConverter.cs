﻿using FoggyInabaConfig.Library.Config.Models;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace FoggyInaba_Config_Adjuster.Helpers;

internal class ColorToConfigColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ConfigColor color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        return Color.FromArgb(byte.MaxValue, 0, 0, 0);
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is Color color)
        {
            return new ConfigColor(color.R, color.G, color.B, color.A);
        }

        return new ConfigColor(0, 0, 0, byte.MaxValue);
    }
}
