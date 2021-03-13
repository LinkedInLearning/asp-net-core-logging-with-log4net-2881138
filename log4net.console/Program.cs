using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace log4net.console
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            //Load Configuration
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            Console.WriteLine("Hello World!");

            log.Info("This is info");
            log.Debug("This is debug");
            log.Error("This is error");
            log.Warn("This is warn");
            log.Fatal("This is fatal");

            Console.ReadLine();

        }
    }
}
