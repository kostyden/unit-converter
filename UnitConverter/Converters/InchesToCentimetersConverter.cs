namespace UnitConverter.Converters
{
    public class InchesToCentimetersConverter : IUnitConverter
    {
        public string Name { get; }

        public InchesToCentimetersConverter(string name)
        {
            Name = name;
        }

        public double Convert(double value)
        {
            return value * 2.54;
        }
    }
}
