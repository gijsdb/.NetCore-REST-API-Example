using System.Collections.Generic;
using command_api.Data;
using command_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace command_api.Controllers 
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandApiRepo _repository;

        // Dependency injection
        // Allows you to switch out your repository
        public CommandsController(ICommandApiRepo repository)
        {
            _repository = repository;
        }


        // api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            
            return Ok(commandItems);
        }

        // api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}