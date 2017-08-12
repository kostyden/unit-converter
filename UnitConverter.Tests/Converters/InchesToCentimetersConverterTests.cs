namespace UnitConverter.Tests.Converters
{
    using FluentAssertions;
    using NUnit.Framework;
    using UnitConverter.Converters;

    [TestFixture]
    class InchesToCentimetersConverterTests
    {
        [Test]
        [TestCase(10, 25.4)]
        [TestCase(20, 50.8)]
        [TestCase(30, 76.2)]
        [TestCase(40, 101.6)]
        [TestCase(50, 127)]
        [TestCase(100, 254)]
        [TestCase(2.17, 5.5118)]
        [TestCase(1996.1212, 5070.147848)]
        [TestCase(1.3, 3.302)]
        [TestCase(-1.2, -3.048)]
        public void Convert_ShouldReturnExpectedResult(double yards, double expectedMeters)
        {
            var converter = new InchesToCentimetersConverter("");

            var actualMeters = converter.Convert(yards);

            actualMeters.Should().BeApproximately(expectedMeters, 0.001);
        }

        [Test]
        [TestCase("inches->centimeters")]
        [TestCase("some converter")]
        [TestCase("from inches to centimeters")]
        public void Name_ShouldReturnNameProvidedDuringConstruction(string name)
        {
            var converter = new InchesToCentimetersConverter(name);
            converter.Name.Should().Be(name);

        }
    }
}
