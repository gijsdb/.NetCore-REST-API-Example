using System.Collections.Generic;
using command_api.Models;

namespace command_api.Data
{
    public interface ICommandApiRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        
    }
}