namespace UnitConverter.Tests.Converters
{
    using FluentAssertions;
    using NUnit.Framework;
    using UnitConverter.Converters;

    [TestFixture]
    class MilesToKilometersConverterTests
    {
        [Test]
        [TestCase(10, 16.09344)]
        [TestCase(20, 32.18688)]
        [TestCase(30, 48.28032)]
        [TestCase(40, 64.37376)]
        [TestCase(50, 80.4672)]
        [TestCase(100, 160.9344)]
        [TestCase(12.8, 20.5996032)]
        [TestCase(1.1, 1.7702784)]
        [TestCase(24.42, 39.30018048)]
        [TestCase(0.15, 0.2414016)]
        public void Convert_ShouldReturnExpectedResult(double yards, double expectedMeters)
        {
            var converter = new MilesToKilometersConverter("");

            var actualMeters = converter.Convert(yards);

            actualMeters.Should().BeApproximately(expectedMeters, 0.001);
        }

        [Test]
        [TestCase("miles to km")]
        [TestCase("miles")]
        [TestCase("kilometers")]
        public void Name_ShouldReturnNameProvidedDuringConstruction(string name)
        {
            var converter = new MilesToKilometersConverter(name);
            converter.Name.Should().Be(name);

        }
    }
}
