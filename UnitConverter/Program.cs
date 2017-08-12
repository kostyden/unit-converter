
namespace UnitConverter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
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
            var formatter = new TempFormatter();
            var mainViewModel = new MainViewModel(formatter, converters);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(mainViewModel));
        }

        public class TempFormatter : IFormatter
        {
            public IEnumerable<string> ToCollection(string text)
            {
                throw new NotImplementedException();
            }

            public string ToText(IEnumerable<string> collection)
            {
                throw new NotImplementedException();
            }
        }
    }
}
