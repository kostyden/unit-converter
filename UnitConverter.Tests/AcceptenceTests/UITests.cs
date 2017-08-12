namespace UnitConverter.Tests.AcceptenceTests
{
    using NUnit.Framework;
    using System;
    using System.IO;
    using System.Reflection;
    using TestStack.White;
    using TestStack.White.Factory;
    using TestStack.White.UIItems.WindowItems;

    public abstract class UITests
    {
        public static Application LaunchApplication()
        {
            var directoryName = Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath);
            var exePath = Path.Combine(directoryName, @"UnitConverter.exe");
            return Application.Launch(exePath);
        }

        protected Application Application { get; private set; }

        protected Window Window { get; private set; }

        [OneTimeSetUp]
        public void OneTimeSetUpBase()
        {
            Application = LaunchApplication();
            Window = Application.GetWindow(ControlNames.WINDOW_TITLE, InitializeOption.NoCache);
        }

        [OneTimeTearDown]
        public void OneTimeTearDownBase()
        {
            Window.Dispose();
            Application.Dispose();
        }
    }
}
