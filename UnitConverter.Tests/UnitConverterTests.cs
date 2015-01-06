namespace UnitConverter.Tests
{
    using System.Linq;
    using NUnit.Framework;

	[TestFixture]
	public class UnitConverterTests
	{
		[TestCase("1", "0.9144")]
		[TestCase("100", "91.44")]
		[TestCase("5", "4.572")]
		[TestCase("17.96", "16.422624")]
		public void YardsToMeters_GivenSingleValue_ReturnsCorrectString(string input, string expected)
		{
			var converter = new UnitConverter();
            // Assert.Fail();
			Assert.That(converter.YardsToMeters(input).Single(), Is.EqualTo(expected));
		}

		[TestCase("100;5;1", "91.44;4.572;0.9144")]
		[TestCase("1;2;3;4;5", "0.9144;1.8288;2.7432;3.6576;4.572")]
		public void YardsToMeters_GivenMultipleValues_ReturnsCorrectMultiLineString(string input, string expected)
		{
			input = input.Replace(";", "\n");
			var expectedArray = expected.Split(';');

			var converter = new UnitConverter();

			Assert.That(converter.YardsToMeters(input), Is.EqualTo(expectedArray));
		}

		[TestCase("1", "2.54")]
		[TestCase("32", "81.28")]
		[TestCase("87", "220.98")]
		public void InchesToCentimeters_GivenSingleValue_ReturnsCorrectString(string input, string expected)
		{
			var converter = new UnitConverter();

			Assert.That(converter.InchesToCentimeters(input).Single(), Is.EqualTo(expected));
		}

		[TestCase("1;2;3;4;5", "2.54;5.08;7.62;10.16;12.7")]
		[TestCase("89.2;1.75;1984", "226.568;4.445;5039.36")]
		public void InchesToCentimeters_GivenMultipleValues_ReturnsCorrectMultiLineString(string input, string expected)
		{
			input = input.Replace(";", "\n");
			var expectedArray = expected.Split(';');

			var converter = new UnitConverter();

			Assert.That(converter.InchesToCentimeters(input), Is.EqualTo(expectedArray));
		}
	}
}