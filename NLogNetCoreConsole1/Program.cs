using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace NLogNetCoreConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static IServiceProvider BuildDi(IConfiguration config) 
        {
            return new ServiceCollection()
                .AddTransient<Runner>()
                .AddLogging(loggingBuilder => 
                { 
                    loggingBuilder.ClearProviders();
                    loggingBuilder.SetMinimumLevel(LogLevel.Trace);
                    loggingBuilder.AddNLog(config);
                }
                )
                .BuildServiceProvider();
        }
    }
}
