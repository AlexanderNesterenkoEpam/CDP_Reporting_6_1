using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Serilog.Core;

namespace TestWebProject
{
    public static class SerilogLogger
    {
        private static Logger logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .WriteTo.RollingFile("logs\\myapp-{Date}.txt")
            .CreateLogger();

        public static Logger Logger => logger;
    } 
}
