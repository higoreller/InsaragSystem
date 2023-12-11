using AutoMapper;
using InsaragSystem.Application.DTOs.TeamDTOs;
using InsaragSystem.Application.Teams.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<TeamDTO, TeamCreateCommand>();
            CreateMap<TeamDTO, TeamUpdateCommand>();
        }
    }
}
