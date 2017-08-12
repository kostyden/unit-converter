namespace UnitConverter.Converters
{
    public class MilesToKilometersConverter : BaseConverter
    {
        public MilesToKilometersConverter(string name) : base(name)
        {
        }

        public override double Convert(double value)
        {
            return value * 1.609344;
        }
    }
}
