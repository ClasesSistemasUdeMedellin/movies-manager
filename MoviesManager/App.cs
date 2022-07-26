using MoviesManager.Forms;
using MoviesManager.Model;

namespace MoviesManager
{
    internal static class App
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindowForm(new MovieManager()));
        }
    }
}