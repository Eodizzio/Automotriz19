using Frontend.Presentaci�n;
using Frontend.Presentaci�n.Reportes;
using Frontend.Presentaci�n.Reportes.FacturasFechas;
using Frontend.Presentaci�n.Reportes.FacturaTipoCli;
using Frontend.Presentaci�n.Reportes.MarcasVendidas;

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