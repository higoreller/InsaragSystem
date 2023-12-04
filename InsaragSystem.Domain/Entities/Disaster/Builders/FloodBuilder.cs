using InsaragSystem.Domain.Entities.Disaster.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Disaster.Builders
{
    public class FloodBuilder : DisasterBuilder<Flood>
    {
        public FloodBuilder WithFloodedArea (double floodedArea)
        {
            _disaster.FloodedArea = floodedArea;
            return this;
        }
    }
}
