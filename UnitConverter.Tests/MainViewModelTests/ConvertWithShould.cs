namespace UnitConverter.Tests.MainViewModelTests
{
    using FluentAssertions;
    using NSubstitute;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    [TestFixture]
    class ConvertWithShould : MainViewModelTestsBase
    {
        [Test]
        [TestCase(new[] { "10.0", "27.3", "4.2" }, new[] { 200.99, 4.51, 890.7 })]
        [TestCase(new[] { "23.5" }, new[] { -23.7 })]
        public void UpdateResultWithExpectedValue(string[] inputValues, double[] result)
        {
            var rawInput = inputValues.ToMultilineText();
            var expectedValue = result.Select(value => value.ToString()).ToMultilineText();

            FakeFormatter.ToCollection(rawInput).Returns(inputValues);
            FakeFormatter.ToText(null).ReturnsForAnyArgs(expectedValue);
            var converter = ConfigureConverterFor(inputValues, result);

            Viewmodel.ConvertWith(converter, rawInput);

            Viewmodel.Result.Should().Be(expectedValue);
        }

        [Test]
        [TestCase(new[] { "10.0", "27.3", "4.2" }, new[] { 10.0, 27.3, 4.2 })]
        [TestCase(new[] { "-1.2", "3.1415", "0.0" }, new[] { -1.2, 3.1415, 0.0 })]
        [TestCase(new[] { "-1.O2", "3,1415", "zero" }, new[] { double.NaN, double.NaN, double.NaN }, TestName = "PassNaNValueToConverterWhenWrongFormatedValueGiven")]
        public void PassExpectedInputValuesToConverter(string[] inputValues, double[] expectedInput)
        {
            var dummyResult = 0.1;
            var actualInput = new List<double>();
            var inputValue = inputValues.ToMultilineText();

            FakeFormatter.ToCollection(inputValue).ReturnsForAnyArgs(inputValues);
            FakeFormatter.ToText(null).ReturnsForAnyArgs(config => config.Arg<IEnumerable<string>>().ToList().ToString());

            var converter = Substitute.For<IUnitConverter>();
            converter.Convert(Arg.Do<double>(value => actualInput.Add(value))).ReturnsForAnyArgs(dummyResult);

            Viewmodel.ConvertWith(converter, inputValue);

            actualInput.ShouldBeEquivalentTo(expectedInput);
        }

        [Test]
        [TestCase(new[] { "0.8", "89.765", "17.9" }, new[] { -10.9, -1.2, -4.2 })]
        [TestCase(new[] { "0.7", "2.12" }, new[] { -1.0101, 2.13 })]
        public void PassConvertedValuesToFormatterAsCollectionOfInvariantCultureString(string[] inputValues, double[] result)
        {
            var expectedOutputValues = result.Select(value => value.ToString(CultureInfo.InvariantCulture));
            IEnumerable<string> actualOutputValues = null;
            var inputValue = inputValues.ToMultilineText();

            FakeFormatter.ToCollection(inputValue).ReturnsForAnyArgs(inputValues);
            FakeFormatter.ToText(Arg.Do<IEnumerable<string>>(values => actualOutputValues = values)).ReturnsForAnyArgs(string.Empty);

            var converter = ConfigureConverterFor(inputValues, result);

            Viewmodel.ConvertWith(converter, inputValue);

            actualOutputValues.ShouldBeEquivalentTo(expectedOutputValues);
        }

        [Test]
        public void PassNaNValuesToFormatterWhenWrongFormattedValuesGiven()
        {
            var expectedOutputValues = new[] { "NaN", "NaN" };
            IEnumerable<string> actualOutputValues = null;
            var inputValues = new[] { "2,9", "1.O8" };
            var inputValue = inputValues.ToMultilineText();
            var parsedValues = new[] { double.NaN, double.NaN };
            var result = new[] { double.NaN, double.NaN };

            FakeFormatter.ToCollection(inputValue).ReturnsForAnyArgs(inputValues);
            FakeFormatter.ToText(Arg.Do<IEnumerable<string>>(values => actualOutputValues = values)).ReturnsForAnyArgs(string.Empty);

            var converter = ConfigureConverterFor(parsedValues, result);

            Viewmodel.ConvertWith(converter, inputValue);

            actualOutputValues.ShouldBeEquivalentTo(expectedOutputValues);
        }


        [Test]
        public void RaisePropertyChangedForResult()
        {
            var converter = Substitute.For<IUnitConverter>();
            Viewmodel.MonitorEvents();

            Viewmodel.ConvertWith(converter, new[] { "23.5", "1.2" }.ToMultilineText());

            Viewmodel.ShouldRaisePropertyChangeFor(viewmodel => viewmodel.Result);
        }

        [Test]
        public void NotThrowExceptionWhenNoSubscribersForPropertyChanged()
        {
            var converter = Substitute.For<IUnitConverter>();
            Action convert = () => Viewmodel.ConvertWith(converter, new[] { "12054" }.ToMultilineText());

            convert.ShouldNotThrow();
        }
    }
}
