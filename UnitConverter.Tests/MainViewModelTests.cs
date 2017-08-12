﻿namespace UnitConverter.Tests
{
    using FluentAssertions;
    using NSubstitute;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    [TestFixture]
    class MainViewModelTests
    {
        private IFormatter _fakeFormatter;

        private MainViewModel _viewmodel;

        [SetUp]
        public void SetUp()
        {
            _fakeFormatter = Substitute.For<IFormatter>();
            _viewmodel = new MainViewModel(_fakeFormatter);
        }

        [Test]
        [TestCase(new[] { "10.0", "27.3", "4.2" }, new[] { 200.99, 4.51, 890.7 })]
        [TestCase(new[] { "23.5" }, new[] { -23.7 })]
        public void ConvertWith_ShouldUpdateResultWithExpectedValue(string[] inputValues, double[] result)
        {
            var rawInput = inputValues.ToMultilineText();
            var expectedValue = result.Select(value => value.ToString()).ToMultilineText();

            _fakeFormatter.ToCollection(rawInput).Returns(inputValues);
            _fakeFormatter.ToText(null).ReturnsForAnyArgs(expectedValue);
            var converter = Substitute.For<IUnitConverter>();
            for(var i = 0; i < inputValues.Length; i++)
            {
                converter.Convert(inputValues[i].ToDouble()).Returns(result[i]);
            }


            _viewmodel.ConvertWith(converter, rawInput);

            _viewmodel.Result.Should().Be(expectedValue);
        }

        [Test]
        [TestCase(new[] { "10.0", "27.3", "4.2" }, new[] { 10.0, 27.3, 4.2 })]
        [TestCase(new[] { "-1.2", "3.1415", "0.0" }, new[] { -1.2, 3.1415, 0.0 })]
        public void ConvertWith_ShouldPassExpectedInputValuesToConverter(string[] inputValues, double[] expectedInput)
        {
            var dummyResult = 0.1;
            var actualInput = new List<double>();
            var inputValue = inputValues.ToMultilineText();

            _fakeFormatter.ToCollection(inputValue).ReturnsForAnyArgs(inputValues);
            var converter = Substitute.For<IUnitConverter>();
            converter.Convert(Arg.Do<double>(value => actualInput.Add(value))).ReturnsForAnyArgs(dummyResult);

            _viewmodel.ConvertWith(converter, inputValue);

            actualInput.ShouldBeEquivalentTo(expectedInput);
        }

        [Test]
        [TestCase(new[] { "0.8", "89.765", "17.9" }, new[] { -10.9, -1.2, -4.2 })]
        [TestCase(new[] { "0.7", "2.12" }, new[] { -1.0101, 2.13 })]
        public void ConvertWith_ShouldPassConvertedValuesToFormatterAsCollectionOfInvarianCultureString(string[] inputValues, double[] result)
        {
            var expectedOutputValues = result.Select(value => value.ToString(CultureInfo.InvariantCulture));
            IEnumerable<string> actualOutputValues = null;
            var inputValue = inputValues.Select(value => value.ToString()).ToMultilineText();

            _fakeFormatter.ToCollection(inputValue).ReturnsForAnyArgs(inputValues);
            _fakeFormatter.ToText(Arg.Do<IEnumerable<string>>(values => actualOutputValues = values)).ReturnsForAnyArgs(string.Empty);
            var converter = Substitute.For<IUnitConverter>();
            for (var i = 0; i < inputValues.Length; i++)
            {
                converter.Convert(inputValues[i].ToDouble()).Returns(result[i]);
            }

            _viewmodel.ConvertWith(converter, inputValue);

            actualOutputValues.ShouldBeEquivalentTo(expectedOutputValues);
        }
    }
}