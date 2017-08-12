namespace UnitConverter.Tests.Converters
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using UnitConverter.Converters;

    [TestFixture]
    class YardsToMetersConverterTests
    {
        [Test]
        [TestCase(10, 9.144)]
        [TestCase(20, 18.288)]
        [TestCase(30, 27.432)]
        [TestCase(40, 36.576)]
        [TestCase(50, 45.72)]
        [TestCase(100, 91.44)]
        [TestCase(15.5, 14.1732)]
        [TestCase(99.636, 91.1071584)]
        [TestCase(1.12, 1.024128)]
        [TestCase(3.1415, 2.8725876)]
        public void Convert_ShouldReturnExpectedResult(double yards, double expectedMeters)
        {
            var converter = new YardsToMetersConverter("");

            var actualMeters = converter.Convert(yards);

            actualMeters.Should().BeApproximately(expectedMeters, 0.001);
        }

        [Test]
        [TestCase("converter")]
        [TestCase("testConverter")]
        [TestCase("one to another")]
        public void Name_ShouldReturnNameProvidedDuringConstruction(string name)
        {
            var converter = new YardsToMetersConverter(name);
            converter.Name.Should().Be(name);

        }
    }
}
