using InsaragSystem.Domain.Entities.Disaster.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Disaster.Builders
{
    public class EarthquakeBuilder : DisasterBuilder<Earthquake>
    {
        public EarthquakeBuilder WithMagnitude(double magnitude)
        {
            _disaster.Magnitude = magnitude;
            return this;
        }

        public EarthquakeBuilder WithDepth(double depth)
        {
            _disaster.Depth = depth;
            return this;
        }
    }
}
