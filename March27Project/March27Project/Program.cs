using March27Project.Views;
using March27Project.Controllers;
namespace March27Project
{
    internal static class Program
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
            TextAnalyzerController tac = new TextAnalyzerController();
            Application.Run(new TextAnalyzerForm(tac));
        }
    }
}