using AulaAEDB.Windows.Mock;

namespace AulaAEDB.Windows
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

            MockGenero.CarregaGenero();
            MockAutor.CarregaAutor();

            Application.Run(new FrmMenu());
        }
    }
}