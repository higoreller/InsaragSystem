using InsaragSystem.Application.DTOs.DisasterDTOs;
using InsaragSystem.Application.DTOs.TeamDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.SectorDTOs
{
    public enum SectorCodeDTO
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M,
        N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }

    public class SectorDTO
    {
        public int Id { get; set; }
        public SectorCodeDTO Code { get; set; }
        public List<TeamDTO> AssignedTeams { get; set; }
        public List<SubdivisionDTO> Subdivisions { get; set; }
        public int DisasterId { get; set; }
        public DisasterBaseDTO Disaster { get; set; }
    }
}

