using InsaragSystem.Application.DTOs.DisasterDTOs;
using InsaragSystem.Application.DTOs.SectorDTOs;
using InsaragSystem.Domain.Entities.Disaster;
using InsaragSystem.Domain.Entities.Sector;
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
        public ContactDetailsDTO ContactDetails { get; set; }
        public SupportRequirementsDTO SupportRequirements { get; set; }
        public TeamDetailsDTO TeamDetails { get; set; }
        public int DisasterId { get; set; }
        public int? AssignedSectorId { get; set; }

    }
}
