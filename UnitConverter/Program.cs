
namespace UnitConverter
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var converters = Enumerable.Empty<IUnitConverter>();
            var formatter = new TextFormatter();
            var mainViewModel = new MainViewModel(formatter, converters);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(mainViewModel));
        }
    }
}
