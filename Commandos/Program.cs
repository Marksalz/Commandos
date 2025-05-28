using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            //game.StartGame();
            Logger logger = Logger.GetLogger();
            logger.Log("This is a test log message.");
            string logContent = logger.Read();
            Console.WriteLine($"Log Content: {logContent}");
        }
    }
}
