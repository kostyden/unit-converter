using System.Globalization;
using System.Linq;

namespace UnitConverter
{
	public class UnitConverter
	{
		public string[] YardsToMeters(string yards)
		{
			if (!yards.Contains('\n'))
			{
				double d = double.Parse(yards, CultureInfo.InvariantCulture) * 0.9144;

				string[] array = new string[1];
				array[0] = d.ToString();

				return array;
			}
			else
			{
				double[] doubles = new double[yards.Split('\n').Count()];

				for (int i = 0; i < yards.Split('\n').Count(); i++)
				{
					double value = double.Parse(yards.Split('\n')[i]);
					doubles[i] = value;

					string.Format("{0}", value * 0.9144);
				}

				string[] strings = new string[doubles.Length];

				for (int i = 0; i < yards.Split('\n').Length; i++)
				{
					strings[i] = string.Format("{0}", doubles[i] * 0.9144);
				}

				return strings;
			}
		}
		
		public string[] InchesToCentimeters(string yards)
		{
			if (!yards.Contains('\n'))
			{
				double numbers = double.Parse(yards, CultureInfo.InvariantCulture) * 2.54;

				string[] array = new string[1];
				array[0] = numbers.ToString();

				return array;
			}
			else
			{
				double[] doubles = new double[yards.Split('\n').Count()];

				for (int i = 0; i < yards.Split('\n').Count(); i++)
				{
					double value = double.Parse(yards.Split('\n')[i]);
					doubles[i] = value;

					string.Format("{0}", value * 0.9144);
				}

				string[] strings = new string[doubles.Length];

				for (int i = 0; i < yards.Split('\n').Length; i++)
				{
					strings[i] = string.Format("{0}", doubles[i] * 2.54);
				}

				return strings;
			}
		}
	}
}