namespace UnitConverter
{
    using System.Globalization;
    using System.Linq;

    public class MainViewModel
    {
        private readonly IFormatter _formatter;

        public string Result { get; set; }

        public MainViewModel(IFormatter formatter)
        {
            _formatter = formatter;
        }

        public void ConvertWith(IUnitConverter converter, string values)
        {
            var rawValues = _formatter.ToCollection(values);
            var originalValues = rawValues.Select(value => double.Parse(value, CultureInfo.InvariantCulture));
            var convertedValues = originalValues.Select(value => converter.Convert(value));
            var resulValues = convertedValues.Select(value => value.ToString(CultureInfo.InvariantCulture));
            Result = _formatter.ToText(resulValues.ToList());
        }
    }
}
