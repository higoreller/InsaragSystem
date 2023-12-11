using InsaragSystem.Application.DTOs.DisasterDTOs;
using InsaragSystem.Application.DTOs.SectorDTOs;
using InsaragSystem.Domain.Entities.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.TeamDTOs
{
    public class TeamDTO : TeamBaseDTO
    {
        public ContactDetails ContactDetails { get; set; }
        public SupportRequirements SupportRequirements { get; set; }
        public TeamDetails TeamDetails { get; set; }
        public int DisasterId { get; set; }
        public DisasterBaseDTO Disaster { get; set; }  
        public int? AssignedSectorId { get; set; }
        public SectorDTO AssignedSector { get; set; } 
    }
}
