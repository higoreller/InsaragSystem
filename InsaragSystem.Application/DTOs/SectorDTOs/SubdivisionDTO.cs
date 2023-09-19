using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.SectorDTOs
{
    public class SubdivisionDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public List<SubfieldDTO> Subfields { get; set; }
        public int SectorId { get; set; }
        public SectorDTO Sector { get; set; }
    }

}
