using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4netTutorial
{
    internal class Program
    {
        private static readonly log4net.ILog log = LogHeoper.GetLogger();

        private static void Main(string[] args)
        {
            // ImplementLoggingFuntion();
            Console.WriteLine("Hello world");
            log.Error("This is my error message");

            Console.ReadLine();
        }
    }
}