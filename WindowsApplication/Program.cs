using Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;
using WindowsApplication.Pages;
using Persistence.Contexts;
using Persistence.Repositories;
using Business.Services;
using Persistence;

namespace WindowsApplication
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddSingleton(Configuration);
            services.AddPersistenceServices();
            services.AddTransient<LoginScreen>();
            services.AddBusinessServices();
            services.AddControllers();

            var serviceProvider = services.BuildServiceProvider();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(serviceProvider.GetRequiredService<LoginScreen>());
        }

        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
    }
}
