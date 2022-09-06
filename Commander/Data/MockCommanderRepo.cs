using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommand()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo="clone repo", Line="git clone", Platform="git cmd"},
                new Command {Id=1, HowTo="git push repo", Line="git push", Platform="git cmd"},
                new Command {Id=2, HowTo="check status", Line="git status", Platform="git cmd"}
            };

            return commands;
        }

        public Command GetCommandByID(int Id)
        {
            return new Command {Id=0, HowTo="clone repo", Line="git clone", Platform="git cmd"};
        }
    }
}