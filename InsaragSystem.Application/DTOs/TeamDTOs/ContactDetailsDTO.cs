using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.TeamDTOs
{
    public class ContactDetailsDTO : TeamBaseDTO
    {
        public string Contact1NameOrTitle { get; set; }
        public string Contact1MobilePhoneNumber { get; set; }
        public string Contact1SatellitePhoneNumber { get; set; }
        public string Contact1Email { get; set; }

        public string Contact2NameOrTitle { get; set; }
        public string Contact2MobilePhoneNumber { get; set; }
        public string Contact2SatellitePhoneNumber { get; set; }
        public string Contact2Email { get; set; }

        public string BaseOperationLocation { get; set; }
        public string RadioFrequencyInMHz { get; set; }

        public GpsCoordinatesDTO WorkSiteGpsCoordinates { get; set; }  
    }
}
