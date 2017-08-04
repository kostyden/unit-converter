namespace UnitConverter.Tests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using TestStack.White;
    using TestStack.White.Factory;
    using TestStack.White.UIItems;
    using TestStack.White.UIItems.Finders;

    [TestFixture]
    class AcceptenceTests
    {
        [Test]
        public void OnStartup_HeaderLabelShouldContainExpectedText()
        {
            var expectedText = "Convert values from input box, seperated by a new line, from one unit to another";

            var directoryName = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath);
            var exePath = Path.Combine(directoryName, @"UnitConverter.exe");
            using (var application = Application.Launch(exePath))
            {
                var window = application.GetWindow("Form1", InitializeOption.NoCache);
                var label = window.Get<Label>(SearchCriteria.ByAutomationId("label2"));

                label.Text.Should().Be(expectedText);
            }
        }

        [Test]
        [TestCase(new[] { "10" }, new[] { "9.144" })]
        [TestCase(new[] { "0", "1", "12", "42" }, new[] { "0", "0.9144", "10.9728", "38.4048" })]
        [TestCase(new[] { "150", "1200", "12.1245" }, new[] { "137.16", "1097.28", "11.0866428" })]
        public void WhenInputValidValuesAndClickYardsToMeterButton_ShouldPrintCorrectValuesInResultTextbox(string[] inputValues, string[] expectedResultValues)
        {
            var input = string.Join(Environment.NewLine, inputValues);
            var expectedResult = expectedResultValues.Aggregate(new StringBuilder(),
                                                                (builder, value) => builder.AppendLine(value),
                                                                builder => builder.ToString());

            var directoryName = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath);
            var exePath = Path.Combine(directoryName, @"UnitConverter.exe");
            using (var application = Application.Launch(exePath))
            {
                var window = application.GetWindow("Form1", InitializeOption.NoCache);

                var textBoxInput = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox1"));
                var textBoxResult = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox2"));
                var buttonYardsToMeter = window.Get<Button>(SearchCriteria.ByAutomationId("button1"));

                textBoxInput.BulkText = input;
                buttonYardsToMeter.Click();

                textBoxResult.Text.Should().Be(expectedResult);
            }
        }

        [Test]
        [TestCase(new[] { "4" }, new[] { "10.16" })]
        [TestCase(new[] { "0", "24", "28", "42" }, new[] { "0", "60.96", "71.12", "106.68" })]
        [TestCase(new[] { "100", "3.3333333" }, new[] { "254", "8.466666582" })]
        public void WhenInputValidValuesAndClickInchesInCentimetersButton_ShouldPrintCorrectValuesInResultTextbox(string[] inputValues, string[] expectedResultValues)
        {
            var input = string.Join(Environment.NewLine, inputValues);
            var expectedResult = expectedResultValues.Aggregate(new StringBuilder(),
                                                                (builder, value) => builder.AppendLine(value),
                                                                builder => builder.ToString());

            var directoryName = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath);
            var exePath = Path.Combine(directoryName, @"UnitConverter.exe");
            using (var application = Application.Launch(exePath))
            {
                var window = application.GetWindow("Form1", InitializeOption.NoCache);

                var textBoxInput = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox1"));
                var textBoxResult = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox2"));
                var buttonInchesToCentimeters = window.Get<Button>(SearchCriteria.ByAutomationId("button2"));

                textBoxInput.BulkText = input;
                buttonInchesToCentimeters.Click();

                textBoxResult.Text.Should().Be(expectedResult);
            }
        }
    }
}
