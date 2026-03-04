/* 
Hunter Clezie 
Spring 2026
RCET2265
AddressLabel
github url: https://github.com/hunterclezie-pixel/AddressLabel.git
*/
namespace AddressLabel
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
            Application.Run(new Form1());
        }
    }
}