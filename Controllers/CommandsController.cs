using System.Collections.Generic;
using AutoMapper;
using command_api.Data;
using command_api.Dtos;
using command_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace command_api.Controllers 
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandApiRepo _repository;
        private readonly IMapper _mapper;

        // Dependency injection
        // Allows you to switch out your repository
        public CommandsController(ICommandApiRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        // api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        // api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            if(commandItem != null) {
                 return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }
    }
}