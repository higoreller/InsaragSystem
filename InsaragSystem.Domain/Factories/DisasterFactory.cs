using InsaragSystem.Domain.Entities.Disaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Factories
{
    public static class DisasterFactory
    {
        public static DisasterBase CreateDisaster(DisasterType type)
        {
            switch (type)
            {
                case DisasterType.Wildfire:
                    return new Wildfire();
                case DisasterType.Earthquake:
                    return new Earthquake();
                case DisasterType.Flood:
                    return new Flood();
                default:
                    throw new ArgumentException($"Unsupported disaster type: {type}");
            }
        }
    }
}
