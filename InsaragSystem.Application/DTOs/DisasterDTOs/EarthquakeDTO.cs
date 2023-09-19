using InsaragSystem.Domain.Entities.Disaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.DisasterDTOs
{
    public class EarthquakeDTO : DisasterBaseDTO
    {
        public double Magnitude { get; set; }
        public double Depth { get; set; }
    }
}
