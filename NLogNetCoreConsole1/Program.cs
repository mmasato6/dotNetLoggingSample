using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;

namespace NLogNetCoreConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = LogManager.GetCurrentClassLogger();
            try 
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(System.IO.Directory.GetCurrentDirectory())//From NuGet Package Microsoft.Extensions.Configuration.Json
                    .AddJsonFile("appsettings.json", optional:true,reloadOnChange:true)
                    .Build();
                var serviceProvider = BuildDi(config);
                using (serviceProvider as IDisposable) 
                {
                    var runner = serviceProvider.GetRequiredService<Runner>();
                    runner.DoAction("Action1");
                    // throw new Exception("sample exception"); //例外の動作確認用
                    Console.WriteLine("Press ANY key to exit");
                    Console.ReadKey();
                }
            } 
            catch(Exception ex) 
            {
                // NLog: catch any exception and log it.
                logger.Error(ex, "Stopped program because of exception");
                throw;
            }
            finally 
            {
                // // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
                LogManager.Shutdown();
            }
        }

        private static IServiceProvider BuildDi(IConfiguration config) 
        {
            return new ServiceCollection()
                .AddTransient<Runner>()
                .AddLogging(loggingBuilder => 
                { 
                    loggingBuilder.ClearProviders();
                    loggingBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
                    loggingBuilder.AddNLog(config);
                }
                )
                .BuildServiceProvider();
        }
    }
}
