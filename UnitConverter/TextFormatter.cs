namespace UnitConverter
{
    using System;
    using System.Collections.Generic;

    public class TextFormatter : IFormatter
    {
        public IEnumerable<string> ToCollection(string text)
        {
            return text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
        }

        public string ToText(IEnumerable<string> collection)
        {
            return string.Join(Environment.NewLine, collection);
        }
    }
}
