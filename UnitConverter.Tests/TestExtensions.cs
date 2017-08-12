namespace UnitConverter.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public static class TestExtensions
    {
        public static string ToMultilineText(this IEnumerable<string> values)
        {
            return string.Join(Environment.NewLine, values);
        }

        public static double ToDouble(this string value)
        {
            return double.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}
