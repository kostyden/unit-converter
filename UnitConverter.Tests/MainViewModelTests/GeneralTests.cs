namespace UnitConverter.Tests.MainViewModelTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    class GeneralTests : MainViewModelTestsBase
    {
        [Test]
        [TestCaseSource(nameof(GetTestCasesForConverters))]
        public void Converters_ShouldReturnCollectionGivenDuringConstruction(IUnitConverter[] converters)
        {
            var viewmodel = new MainViewModel(FakeFormatter, converters);
            viewmodel.Converters.ShouldBeEquivalentTo(converters);
        }

        private static IEnumerable<TestCaseData> GetTestCasesForConverters()
        {
            var threeConverters = (object)new IUnitConverter[] { new FirstConverter(), new SecondConverter(), new ThirdConverter() };
            yield return new TestCaseData(threeConverters);

            var twoConverters = (object)new IUnitConverter[] { new SecondConverter(), new ThirdConverter(), new FourthConverter() };
            yield return new TestCaseData(
                (object)new IUnitConverter[]
                {
                    new FirstConverter(),
                    new ThirdConverter(),
                });

            var noConverters = Enumerable.Empty<IUnitConverter>();
            yield return new TestCaseData(noConverters);
        }

        private class FirstConverter : BaseConverter { }

        private class SecondConverter : BaseConverter { }

        private class ThirdConverter : BaseConverter { }

        private class FourthConverter : BaseConverter { }

        private abstract class BaseConverter : IUnitConverter
        {
            public double Convert(double value)
            {
                throw new NotImplementedException();
            }
        }
    }
}
