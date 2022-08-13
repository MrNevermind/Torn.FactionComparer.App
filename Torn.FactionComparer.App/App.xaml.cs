using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows;
using Torn.FactionComparer.App.Infrastructure;
using Torn.FactionComparer.App.Models;
using Torn.FactionComparer.App.Services;
using Torn.FactionComparer.App.ViewModels;

namespace Torn.FactionComparer.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();

            services.AddSingleton<IMainViewModel, MainViewModel>();

            services.AddHttpClient();
            services.AddSingleton<ICompareDataRetriever, CompareDataRetriever>();
            services.AddSingleton<IHtmlRenderer, HtmlRenderer>();
            services.AddSingleton<IImageGenerator, ImageGenerator>();

            services.AddDbContext<TornContext>(options => options.UseSqlite($"Data Source = {Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Torn.FactionComparer.Cache.db")}"));
            services.AddSingleton<ITornContext, TornContext>();

            services.AddSingleton<IDbService, DbService>();
            services.AddSingleton<IStatsCalculator, StatsCalculator>();

            services.AddSingleton<IMainModel, MainModel>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
