using EconomicMF.Forms.Forms.Users;
using EconomicMF.SettingForms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace EconomicMF
{
    static class Program 
    {
        public static IConfiguration? Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            
            SingletonFrm.GetInstances(services);

            using (var serivceScope = services.BuildServiceProvider())
            {
                ServicesReq.ServiceProvider = serivceScope;
                var main = serivceScope.GetRequiredService<FrmLogin>();
                Application.Run(main);
            }
        }
    }
}
