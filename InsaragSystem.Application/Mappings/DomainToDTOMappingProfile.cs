using AutoMapper;
using InsaragSystem.Application.DTOs;
using InsaragSystem.Application.DTOs.DisasterDTOs;
using InsaragSystem.Application.DTOs.SectorDTOs;
using InsaragSystem.Application.DTOs.TeamDTOs;
using InsaragSystem.Application.Teams.Commands;
using InsaragSystem.Domain.Entities;
using InsaragSystem.Domain.Entities.Disaster;
using InsaragSystem.Domain.Entities.Sector;
using InsaragSystem.Domain.Entities.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() { 
            CreateMap<DisasterBase, DisasterBaseDTO>().ReverseMap();
            CreateMap<Earthquake, EarthquakeDTO>().ReverseMap();
            CreateMap<Flood, FloodDTO>().ReverseMap();
            CreateMap<Wildfire, WildfireDTO>().ReverseMap();
            CreateMap<Sector, SectorDTO>().ReverseMap();
            CreateMap<Subdivision, SubdivisionDTO>().ReverseMap();
            CreateMap<Subfield, SubfieldDTO>().ReverseMap();
            CreateMap<ContactDetails, ContactDetailsDTO>().ReverseMap();
            CreateMap<SupportRequirements, SupportRequirementsDTO>().ReverseMap();
            CreateMap<TeamDetails, TeamDetailsDTO>().ReverseMap();
            CreateMap<TeamBase, TeamBaseDTO>().ReverseMap();
            CreateMap<Team, TeamDTO>().ReverseMap();
            CreateMap<GpsCoordinates, GpsCoordinatesDTO>().ReverseMap();
            
        }
    }
}
