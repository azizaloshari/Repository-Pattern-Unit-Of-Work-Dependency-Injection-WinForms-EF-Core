using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RepositoryPatternAndUnitOfWorkInWinforms.EFCore;
using RepositoryPatternAndUnitOfWorkInWinforms.Infrastructure.Persistence;
using System;

namespace RepositoryPatternAndUnitOfWorkInWinforms.App
{
    internal static class Program
    {
        public static IServiceProvider? serviceProvider  { get;private set; }
       // public static  IUnitOfWork? _UOW { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
         Host.CreateDefaultBuilder()
                  .ConfigureServices((hostcontext, services) =>
                  {
                      services.GetServices();
                      serviceProvider = services.BuildServiceProvider();
                  }).Build();
            //var logger=host.Services.GetRequiredService<ILogger>();
            using (IServiceScope? scope = serviceProvider?.CreateScope())
            {
               // _UOW = scope.ServiceProvider.GetRequiredService<IUnitOfWork>();
               AppUnit.SetUnitOfWork= scope?.ServiceProvider.GetRequiredService<IUnitOfWork>();
            }
           // ServicesProvider=host.Services.CreateScope().ServiceProvider;
            

            Application.Run(new Form1());
        }
    }
}