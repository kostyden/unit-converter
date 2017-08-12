namespace UnitConverter
{    
    using System.Collections.Generic;

    public interface IFormatter
    {
        string ToText(IEnumerable<string> collection);

        IEnumerable<string> ToCollection(string text);
    }
}
