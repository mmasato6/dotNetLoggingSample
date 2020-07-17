using System;
using Microsoft.Extensions.Logging;

namespace NetCoreConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var loggerFactory = LoggerFactory.Create(builder => 
            {
                builder
                .AddFilter($"{nameof(NetCoreConsoleApp1)}.{nameof(Program)}",LogLevel.Trace)
                .AddConsole()
                .AddDebug()
                ;
            });
            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("Information dayo");
            logger.LogTrace("Trace dayo");
            logger.LogDebug("Debug dayo");
            logger.LogWarning("Warning dayo");
            logger.LogError("Error dayo");
            Console.WriteLine("Hello World!");
            Console.ReadLine(); //そのまま終了するとコンソールにログが出ない。ログが出る前にプロセスが終わってる？(未確認)
        }
    }
}
