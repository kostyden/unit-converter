namespace UnitConverter.Tests.AcceptenceTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Linq;
    using TestStack.White.UIItems;
    using TestStack.White.UIItems.Finders;
    using TestStack.White.UIItems.TableItems;
    using TestStack.White.UIItems.WindowItems;
    using UnitConverter.Resources;

    [TestFixture]
    [Category("Acceptence tests")]
    class OnStartupShouldDisplay : UITests
    {
        [Test]
        public void ExpectedMainTitle()
        {
            var label = Window.Get<Label>(SearchCriteria.ByAutomationId(ControlNames.LABEL_MAIN_TITLE));

            label.Text.Should().Be(ControlTexts.MainTitle);
        }

        [Test]
        public void ExpectedInputTitle()
        {
            var label = Window.Get<Label>(SearchCriteria.ByAutomationId(ControlNames.LABEL_INPUT_TITLE));

            label.Text.Should().Be(ControlTexts.InputTitle);
        }

        [Test]
        public void ExpectedResultTitle()
        {
            var label = Window.Get<Label>(SearchCriteria.ByAutomationId(ControlNames.LABEL_RESULT_TITLE));

            label.Text.Should().Be(ControlTexts.ResultTitle);
        }

        [Test]
        public void EmptyInputTextBox()
        {
            var textBox = Window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_INPUT));
            textBox.Text.Should().BeEmpty();
        }

        [Test]
        public void EmptyResultTextBox()
        {
            var textBox = Window.Get<TextBox>(SearchCriteria.ByAutomationId(ControlNames.TEXTBOX_RESULT));
            textBox.Text.Should().BeEmpty();
        }

        [Test]
        public void ExpectedConvertButtons()
        {
            var expectedButtonsText = new[]
            {
                ConverterNames.YardsToMeters,
                ConverterNames.InchesToCentimeters,
                ConverterNames.MilesToKilometers
            };
            var gridView = Window.Get<Table>(SearchCriteria.ByAutomationId(ControlNames.DATAGRIDVIEW_CONVERTERS));
            var actualButtonsText = gridView.Rows.Select(row => row.Cells[0]).Select(cell => cell.Value);

            actualButtonsText.ShouldBeEquivalentTo(expectedButtonsText);
        }
    }
}
