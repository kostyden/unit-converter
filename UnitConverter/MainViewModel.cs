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

        public string Result { get; set; }

        public MainViewModel(IFormatter formatter, IEnumerable<IUnitConverter> converters)
        {
            _formatter = formatter;
            Converters = new ReadOnlyCollection<IUnitConverter>(converters.ToList());
        }

        public void ConvertWith(IUnitConverter converter, string values)
        {
            var rawValues = _formatter.ToCollection(values);
            var originalValues = rawValues.Select(value => double.Parse(value, CultureInfo.InvariantCulture));
            var convertedValues = originalValues.Select(value => converter.Convert(value));
            var resulValues = convertedValues.Select(value => value.ToString(CultureInfo.InvariantCulture));
            Result = _formatter.ToText(resulValues.ToList());
            RaisePropertyChanged(nameof(Result));
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
