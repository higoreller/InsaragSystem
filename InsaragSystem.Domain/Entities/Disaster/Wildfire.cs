﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Disaster
{
    public class Wildfire : DisasterBase
    {
        public decimal BurnedArea { get; set; }
    }
}
