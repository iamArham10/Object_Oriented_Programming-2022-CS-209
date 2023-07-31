using Pharmacy_Management_System.DL;

namespace Pharmacy_Management_System
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
            if (UserDL.Load_Users()) MessageBox.Show("Users Loaded");
            if (MedicineDL.Load_Medicine_Data()) MessageBox.Show($"Medicines Loaded");
            ApplicationConfiguration.Initialize();
            Main_Menu Main = new();
            Application.Run(Main);
        }
    }
}