namespace UnitConverter.Converters
{
    public abstract class BaseConverter : IUnitConverter
    {
        public string Name { get; }

        public BaseConverter(string name)
        {
            Name = name;
        }

        public abstract double Convert(double value);
    }
}
