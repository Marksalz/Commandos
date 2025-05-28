using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Logger
    {
        private static Logger _instance = null;

        private Logger()
        {
            // Private constructor to prevent instantiation
        }

        public static Logger GetLogger()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }
            return _instance;
        }

        public void Log(string message)
        {
            string writePath = ".log.txt";
            string logMessage = $"{DateTime.Now}: {message}";
            File.WriteAllText(writePath, logMessage);
        }

        public string Read()
        {
            string readPath = ".log.txt";
            if (File.Exists(readPath))
            {
                return File.ReadAllText(readPath);
            }
            else
            {
                return "Log file does not exist.";
            }
        }
    }
}
