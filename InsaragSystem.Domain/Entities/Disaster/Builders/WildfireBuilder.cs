using InsaragSystem.Domain.Entities.Disaster.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Disaster.Builders
{
    public class WildfireBuilder : DisasterBuilder<Wildfire>
    {
        public WildfireBuilder WithBurnedArea (decimal burnedArea) 
        {
            _disaster.BurnedArea = burnedArea;
            return this;
        }
    }
}
