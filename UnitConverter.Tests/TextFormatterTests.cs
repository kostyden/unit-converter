namespace UnitConverter.Tests
{
    using FluentAssertions;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    [TestFixture]
    class TextFormatterTests
    {
        [Test]
        [TestCaseSource(nameof(GetCasesForCollectionTests))]
        public void ToCollection_ShouldReturnCollectionOfValuesSeparatedByNewLine(string givenValue, string[] expectedCollection)
        {
            var formatter = new TextFormatter();
            var actualCollection = formatter.ToCollection(givenValue);

            actualCollection.ShouldBeEquivalentTo(expectedCollection);
        }

        private static IEnumerable<TestCaseData> GetCasesForCollectionTests()
        {
            var inputBuilder = new StringBuilder().AppendLine("3.2").AppendLine("1.998").AppendLine("3.14").AppendLine("42");
            var expected = new[] { "3.2", "1.998", "3.14", "42" };
            yield return new TestCaseData(inputBuilder.ToString(), expected);

            inputBuilder.Clear().Append("0.000100100001001");
            expected = new[] { "0.000100100001001" };
            yield return new TestCaseData(inputBuilder.ToString(), expected);

            inputBuilder.Clear();
            expected = Enumerable.Empty<string>().ToArray();
            yield return new TestCaseData(inputBuilder.ToString(), expected);
        }

        [Test]
        [TestCaseSource(nameof(GetCasesForToTextTests))]
        public void ToText_ShouldReturnGivenValuesSeparatedByNewLine(string[] givenCollection, string expected)
        {
            var formatter = new TextFormatter();
            var actual = formatter.ToText(givenCollection);

            actual.Should().Be(expected);
        }

        private static IEnumerable<TestCaseData> GetCasesForToTextTests()
        {
            var input = new[] { "1.0", "2.1", "3.22", "-3.98", "NaN", "34", "22.0" };
            var outputBuilder = new StringBuilder().AppendLine("1.0")
                                                   .AppendLine("2.1")
                                                   .AppendLine("3.22")
                                                   .AppendLine("-3.98")
                                                   .AppendLine("NaN")
                                                   .AppendLine("34")
                                                   .Append("22.0");
            yield return new TestCaseData(input, outputBuilder.ToString());

            input = new[] { "1.002" };
            outputBuilder.Clear().Append("1.002");
            yield return new TestCaseData(input, outputBuilder.ToString());

            input = Enumerable.Empty<string>().ToArray();
            outputBuilder.Clear();
            yield return new TestCaseData(input, outputBuilder.ToString());
        }
    }
}
