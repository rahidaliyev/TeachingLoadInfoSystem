using TeachingLoadInfoSystem;
using TeachingLoadInfoSystem;
using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem
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
            User user = new User() 
            {
                UserName = "sa",
                UserPassword= "1",
            };
            //Application.Run(new TLMenu(user));
            Application.Run(new Login());
            //Application.Run(new JoinForGroupAndEducationPlanForm());
        }
    }
}