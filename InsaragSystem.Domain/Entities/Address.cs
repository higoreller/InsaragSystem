﻿using InsaragSystem.Domain.Entities.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int TeamId { get; set; }
        public Team.Team Team { get; set; }
    }
}
