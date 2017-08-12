namespace UnitConverter
{
    public interface IUnitConverter
    {
        string Name { get; }

        double Convert(double value);
    }
}
