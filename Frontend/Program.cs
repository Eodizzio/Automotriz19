using Frontend.Presentación;
using Frontend.Presentación.Reportes;
using Frontend.Presentación.Reportes.FacturasFechas;
using Frontend.Presentación.Reportes.FacturaTipoCli;
using Frontend.Presentación.Reportes.MarcasVendidas;

namespace Frontend
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
            Application.Run(new FrmLogin());
        }
    }
}