using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Get your external IP address", Line = "curl ifconfig.me", Platform = "Linux" },
                new Command { Id = 1, HowTo = "Run the last command as root", Line = "sudo !!", Platform = "Linux" },
                new Command { Id = 2, HowTo = "Clear terminal screen", Line = "ctrl+l", Platform = "Linux" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Display top ten running processes - sorted by memory usage", Line = "ps aux | sort -nk +4 | tail", Platform = "Linux" };
        }
    }
}