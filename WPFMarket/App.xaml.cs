using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Reflection;
using System.Windows.Threading;
using Wpf.Ui;
using WPFMarket.Services;
using WPFMarket.ViewModels.Pages;
using WPFMarket.ViewModels.Windows;
using WPFMarket.Views.Pages;
using WPFMarket.Views.Windows;
using dotenv.net;
using WPFMarket.Models.Database;
using Microsoft.EntityFrameworkCore;
using WPFMarket.Views.Pages.Admin;
using WPFMarket.Views.Pages.Operator;
using WPFMarket.Views.Pages.Cashier;

namespace WPFMarket
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        // The.NET Generic Host provides dependency injection, configuration, logging, and other services.
        // https://docs.microsoft.com/dotnet/core/extensions/generic-host
        // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
        // https://docs.microsoft.com/dotnet/core/extensions/configuration
        // https://docs.microsoft.com/dotnet/core/extensions/logging
        private static readonly IHost _host = Host
            .CreateDefaultBuilder()
            .ConfigureAppConfiguration(c => { c.SetBasePath(Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location)); })
            .ConfigureServices((context, services) =>
            {
                services.AddHostedService<ApplicationHostService>();

                // Page resolver service
                services.AddSingleton<IPageService, PageService>();

                // Theme manipulation
                services.AddSingleton<IThemeService, ThemeService>();

                // TaskBar manipulation
                services.AddSingleton<ITaskBarService, TaskBarService>();

                // Service containing navigation, same as INavigationWindow... but without window
                services.AddSingleton<INavigationService, NavigationService>();

                // Main window with navigation
                services.AddSingleton<INavigationWindow, MainWindow>();
                services.AddSingleton<MainWindowViewModel>();

                // Settings page
                services.AddSingleton<SettingsPage>();
                services.AddSingleton<SettingsViewModel>();

                // Operator page + subpages
                services.AddSingleton<OperatorPage>();
                services.AddSingleton<OperatorViewModel>();
                
                // Admin page + subpages
                services.AddSingleton<AdminPage>();
                services.AddSingleton<AdminViewModel>();

                // Cashier page + subpages
                services.AddSingleton<CashierPage>();
                services.AddSingleton<CashierViewModel>();

                services.AddDbContext<SupermarketContext>();
            }).Build();

        /// <summary>
        /// Gets registered service.
        /// </summary>
        /// <typeparam name="T">Type of the service to get.</typeparam>
        /// <returns>Instance of the service or <see langword="null"/>.</returns>
        public static T GetService<T>()
            where T : class
        {
            return _host.Services.GetService(typeof(T)) as T;
        }

        /// <summary>
        /// Occurs when the application is loading.
        /// </summary>
        private void OnStartup(object sender, StartupEventArgs e)
        {
            _host.Start();
            DotEnv.Load();

            var dbContext = _host.Services.GetRequiredService<SupermarketContext>();
            //dbContext.Database.EnsureCreated();
            dbContext.Database.Migrate();
        }

        /// <summary>
        /// Occurs when the application is closing.
        /// </summary>
        private async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();

            _host.Dispose();
        }

        /// <summary>
        /// Occurs when an exception is thrown by an application but not handled.
        /// </summary>
        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // For more info see https://docs.microsoft.com/en-us/dotnet/api/system.windows.application.dispatcherunhandledexception?view=windowsdesktop-6.0
        }
    }
}
