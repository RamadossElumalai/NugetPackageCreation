using System;

namespace ApplicationLogger
{
    public class Logger
    {
        /// <summary>
        /// This Method is used to log message in the console
        /// </summary>
        /// <param name="message"></param>
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
