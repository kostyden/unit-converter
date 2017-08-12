namespace UnitConverter
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IFormatter _formatter;

        public event PropertyChangedEventHandler PropertyChanged;

        public IReadOnlyCollection<IUnitConverter> Converters { get; }

        private string _result;

        public string Result
        {
            get
            {
                return _result;
            }

            private set
            {
                _result = value;
                RaisePropertyChanged();
            }
        }

        public MainViewModel(IFormatter formatter, IEnumerable<IUnitConverter> converters)
        {
            _formatter = formatter;
            Converters = new ReadOnlyCollection<IUnitConverter>(converters.ToList());
        }

        public void ConvertWith(IUnitConverter converter, string values)
        {            
            var converted = _formatter.ToCollection(values)
                                      .Select(ParseToDouble)
                                      .Select(converter.Convert)
                                      .Select(ConvertToString);

            Result = _formatter.ToText(converted);
        }

        private double ParseToDouble(string value)
        {
            var allowedStyles = NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint;
            if (double.TryParse(value, allowedStyles, CultureInfo.InvariantCulture, out double parsed))
            {
                return parsed;
            }

            return double.NaN;
        }

        private string ConvertToString(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
