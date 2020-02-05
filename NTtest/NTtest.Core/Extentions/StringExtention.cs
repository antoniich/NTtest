using System;
using System.Collections.Generic;
using System.Text;

namespace NTtest.Core.Extentions
{
    public static class StringExtention
    {
        public static T ToEnum<T>(this string value, T defaultValue) where T : struct
        {
            return Enum.TryParse<T>(value, true, out T outValue) ? outValue : defaultValue;
        }

        public static TimeSpan ToTimeSpanFromMiliseconds(this string value)
        {
            if (double.TryParse(value, out double dblValue))
                return TimeSpan.FromMilliseconds(dblValue);
            else
                throw new FormatException($"Cannot convert '{value}' to double. If this value from config file please check is it proper defined");
        }

        public static Version ToVersion(this string value)
        {
            if (Version.TryParse(value, out Version version))
                return version;
            else
                throw new FormatException($"Cannot convert '{value}' to Version. If this value from config file please check is it proper defined");
        }

        public static bool ToBool(this string value)
        {
            if (bool.TryParse(value, out bool outValue))
                return outValue;
            else
                throw new FormatException($"Cannot convert '{value}' to bool.");
        }
    }
}