using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.SectorDTOs
{
    public class SubfieldDTO
    {
        public int Id { get; set; }
        public char Code { get; set; }
        public int SubdivisionId { get; set; }
        public SubdivisionDTO Subdivision { get; set; }
    }
}
