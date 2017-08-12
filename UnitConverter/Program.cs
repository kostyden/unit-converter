
namespace UnitConverter
{
    using System;
    using System.Windows.Forms;
    using UnitConverter.Converters;

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mainViewModel = CreateMainViewModelWithDependencies();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(mainViewModel));
        }

        static MainViewModel CreateMainViewModelWithDependencies()
        {
            var converters = new IUnitConverter[]
            {
                new YardsToMetersConverter("Yards to Meters"),
                new InchesToCentimetersConverter("Inches To Centimeters")
            };
            var formatter = new TextFormatter();
            return new MainViewModel(formatter, converters);
        }
    }
}
