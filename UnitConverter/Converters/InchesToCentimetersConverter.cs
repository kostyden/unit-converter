namespace UnitConverter.Converters
{
    public class InchesToCentimetersConverter : BaseConverter
    {
        public InchesToCentimetersConverter(string name) : base(name)
        { }

        public override double Convert(double value)
        {
            return value * 2.54;
        }
    }
}
