using System.Collections.Generic;
using command_api.Models;

namespace command_api.Data
{
    public class MockCommandRepo : ICommandApiRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="boil egg", Platform="water"},
                new Command{Id=1, HowTo="Boil an onion", Line="boil onion", Platform="water"},
                new Command{Id=2, HowTo="Boil an cheese", Line="boil cheese", Platform="water"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="boil egg", Platform="water"};
        }
    }
}