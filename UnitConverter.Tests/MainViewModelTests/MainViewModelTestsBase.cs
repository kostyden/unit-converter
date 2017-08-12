namespace UnitConverter.Tests.MainViewModelTests
{
    using FluentAssertions;
    using NSubstitute;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System;

    class MainViewModelTestsBase
    {
        protected IFormatter FakeFormatter { get; private set; }

        protected MainViewModel Viewmodel { get; set; }

        [SetUp]
        public void SetUpBase()
        {
            FakeFormatter = Substitute.For<IFormatter>();
            Viewmodel = new MainViewModel(FakeFormatter, Enumerable.Empty<IUnitConverter>());
        }

        protected IUnitConverter ConfigureConverterFor(string[] input, double[] output)
        {
            var inputValues = input.Select(TestExtensions.ToDouble).ToArray();
            return ConfigureConverterFor(inputValues, output);
        }

        protected IUnitConverter ConfigureConverterFor(double[] input, double[] output)
        {
            var converter = Substitute.For<IUnitConverter>();
            for (var i = 0; i < input.Length; i++)
            {
                converter.Convert(input[i]).Returns(output[i]);
            }

            return converter;
        }
    }
}
