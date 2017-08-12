namespace UnitConverter.Tests.AcceptenceTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using System.Linq;
    using TestStack.White.Factory;
    using TestStack.White.UIItems;
    using TestStack.White.UIItems.Finders;
    using TestStack.White.UIItems.TableItems;
    using TestStack.White.UIItems.WindowItems;
    using UnitConverter.Resources;

    [TestFixture]
    [Category("Acceptence tests")]
    class ConversionTests
    {
        [Test]
        [TestCase(new[] { "0", "1", "12", "42" }, new[] { "0", "0.9144", "10.9728", "38.4048" })]
        [TestCase(new[] { "10" }, new[] { "9.144" })]
        [TestCase(new[] { "150", "1200", "12.1245" }, new[] { "137.16", "1097.28", "11.0866428" })]
        [TestCase(new[] { "201", "1,45d", "forty-two" }, new[] { "183.7944", "NaN", "NaN" })]
        public void YardsToMetersShouldPrintExpectedResult(string[] input, string[] result)
        {
            var givenInput = string.Join(Environment.NewLine, input);
            var expectedResult = result.ToMultilineText();

            using (var application = UITests.LaunchApplication())
            {
                var window = application.GetWindow(ControlTexts.WindowTitle, InitializeOption.NoCache);

                var inputBox = window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_INPUT));
                var resultBox = window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_RESULT));
                var conversionCell = GetConversionCellButtonByText(window, ConverterNames.YardsToMeters);

                inputBox.Text = givenInput;
                conversionCell.Click();

                resultBox.Text.Should().Be(expectedResult);
            }
        }

        [Test]
        [TestCase(new[] { "4" }, new[] { "10.16" })]
        [TestCase(new[] { "0", "24", "28", "42" }, new[] { "0", "60.96", "71.12", "106.68" })]
        [TestCase(new[] { "100", "3.3333333" }, new[] { "254", "8.466666582" })]
        [TestCase(new[] { "45.789", "zero", "0.0" }, new[] { "116.30406", "NaN", "0" })]
        public void InchesInCentimetersShouldPrintExpectedResult(string[] input, string[] result)
        {
            var givenInput = string.Join(Environment.NewLine, input);
            var expectedResult = result.ToMultilineText();

            using (var application = UITests.LaunchApplication())
            {
                var window = application.GetWindow(ControlTexts.WindowTitle, InitializeOption.NoCache);

                var inputBox = window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_INPUT));
                var resultBox = window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_RESULT));
                var conversionCell = GetConversionCellButtonByText(window, ConverterNames.InchesToCentimeters);

                inputBox.Text = givenInput;
                conversionCell.Click();

                resultBox.Text.Should().Be(expectedResult);
            }
        }

        [Test]
        [TestCase(new[] { "4" }, new[] { "6.437376" })]
        [TestCase(new[] { "0", "7", "2.5", "10" }, new[] { "0", "11.265408", "4.02336", "16.09344" })]
        [TestCase(new[] { "100", "0.621371192237334" }, new[] { "160.9344", "1" })]
        [TestCase(new[] { "empty" }, new[] { "NaN" })]
        public void MilesToKilometersShouldPrintExpectedResult(string[] input, string[] result)
        {
            var givenInput = string.Join(Environment.NewLine, input);
            var expectedResult = result.ToMultilineText();

            using (var application = UITests.LaunchApplication())
            {
                var window = application.GetWindow(ControlTexts.WindowTitle, InitializeOption.NoCache);

                var inputBox = window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_INPUT));
                var resultBox = window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_RESULT));
                var conversionCell = GetConversionCellButtonByText(window, ConverterNames.MilesToKilometers);

                inputBox.Text = givenInput;
                conversionCell.Click();

                resultBox.Text.Should().Be(expectedResult);
            }
        }

        private TableCell GetConversionCellButtonByText(Window window, string text)
        {
            var gridView = window.Get<Table>(SearchCriteria.ByAutomationId(ControlNames.DATAGRIDVIEW_CONVERTERS));
            return gridView.Rows.FirstOrDefault(row => row.Cells[0].Value.Equals(text)).Cells[0];
        }
    }
}
