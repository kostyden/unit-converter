namespace UnitConverter.Tests.AcceptenceTests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Linq;
    using TestStack.White.UIItems;
    using TestStack.White.UIItems.Finders;
    using TestStack.White.UIItems.TableItems;
    using TestStack.White.UIItems.WindowItems;

    [TestFixture]
    [Category("Acceptence tests")]
    class OnStartupShouldDisplay : UITests
    {
        [Test]
        public void ExpectedMainTitle()
        {
            var expected = "Convert values from input box, seperated by a new line, from one unit to another";
            var label = Window.Get<Label>(SearchCriteria.ByAutomationId(ControlNames.LABEL_MAIN_TITLE));

            label.Text.Should().Be(expected);
        }

        [Test]
        public void ExpectedInputTitle()
        {
            var expected = "Input";
            var label = Window.Get<Label>(SearchCriteria.ByAutomationId(ControlNames.LABEL_INPUT_TITLE));

            label.Text.Should().Be(expected);
        }

        [Test]
        public void ExpectedResultTitle()
        {
            var expected = "Result";
            var label = Window.Get<Label>(SearchCriteria.ByAutomationId(ControlNames.LABEL_RESULT_TITLE));

            label.Text.Should().Be(expected);
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
                "Yards to Meters",
                "Inches To Centimeters"
            };
            var gridView = Window.Get<Table>(SearchCriteria.ByAutomationId(ControlNames.DATAGRIDVIEW_CONVERTERS));
            var actualButtonsText = gridView.Rows.Select(row => row.Cells[0]).Select(cell => cell.Value);

            actualButtonsText.ShouldBeEquivalentTo(expectedButtonsText);
        }
    }
}
