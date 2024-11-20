using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PaycardEditor.Applications;
using PaycardEditor.Infrastructure;

namespace PaycardEditor.WinForms
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.Run(ServiceProvider.GetRequiredService<MainPage>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var config = new ConfigurationBuilder().SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            services.AddInfrastructure(config);
            services.AddApplication();

            services.AddSingleton<MainPage>();
            services.AddTransient<AddPaycardPage>();
        }
    }
}