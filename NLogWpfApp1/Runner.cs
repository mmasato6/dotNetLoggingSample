using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace NLogWpfApp1
{
    class Runner
    {
        private readonly ILogger<Runner> logger;

        public Runner(ILogger<Runner> logger)
        {
            this.logger = logger;
        }

        public void DoAction(string name)
        {
            logger.LogDebug(20, "Doing hard work! {Action}", name);
        }
    }
}
