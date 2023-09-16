using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Disaster
{
    public class Earthquake : DisasterBase
    {
        public double Magnitude { get; set; } 
        public double Depth { get; set; }
    }
}
