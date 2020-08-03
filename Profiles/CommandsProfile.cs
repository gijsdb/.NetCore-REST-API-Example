using AutoMapper;
using command_api.Dtos;
using command_api.Models;

/* 
    Automatically maps from Command to CommandReadDto using mapper
*/

namespace command_api.Profiles 
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}