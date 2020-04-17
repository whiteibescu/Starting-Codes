using System;

namespace DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger // IformattableLogger는 ILogger를 상속
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger // ConsoleLogger2는 IFormattableLogger를 상속
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}",
                DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is not flat.");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}