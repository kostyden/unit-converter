namespace UnitConverter.Converters
{
    public class YardsToMetersConverter : IUnitConverter
    {
        public string Name { get; }

        public YardsToMetersConverter(string name)
        {
            Name = name;
        }

        public double Convert(double value)
        {
            return value * 0.9144;
        }
    }
}
