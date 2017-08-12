namespace UnitConverter.Converters
{
    public class YardsToMetersConverter : BaseConverter
    {
        public YardsToMetersConverter(string name) : base(name)
        { }

        public override double Convert(double value)
        {
            return value * 0.9144;
        }
    }
}
