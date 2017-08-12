namespace UnitConverter.Tests
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public static class TestExtensions
    {
        public static string ToMultilineText(this IEnumerable<string> values)
        {
            return values.Aggregate(new StringBuilder(),
                                    (builder, value) => builder.AppendLine(value),
                                    builder => builder.ToString());
        }

        public static double ToDouble(this string value)
        {
            return double.Parse(value, CultureInfo.InvariantCulture);
        }
    }
}
