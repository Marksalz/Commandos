using System;
using System.Collections.Generic;

namespace Commandos
{
    internal class CommandoFactory
    {
        public enum CommandoType
        {
            Regular,
            Sea,
            Air
        }

        private Dictionary<string, Func<string, int, ICommando>> commandoCreators;

        public CommandoFactory()
        {
            commandoCreators = new Dictionary<string, Func<string, int, ICommando>>();
        }

        public void RegisterCommando(string commandoType, Func<string, int, ICommando> creator)
        {
            if (!commandoCreators.ContainsKey(commandoType))
                commandoCreators[commandoType] = creator;
            else
                Console.WriteLine($"Commando type {commandoType} is already registered.");
        }

        public ICommando CreateCommando(string commandoType, string name, int codeName)
        {
            if (commandoCreators.ContainsKey(commandoType))
                return commandoCreators[commandoType](name, codeName);
            else
            {
                Console.WriteLine($"Commando type {commandoType} is not registered.");
                return null;
            }
        }
    }
}
