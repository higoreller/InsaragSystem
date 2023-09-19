using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Application.DTOs.TeamDTOs
{
    public class SupportRequirementsDTO : TeamBaseDTO
    {
        public int TotalPeopleToTransport { get; set; }
        public int TotalDogsToTransport { get; set; }
        public double TotalEquipmentWeightInTons { get; set; }
        public double TotalEquipmentVolumeInCubicMeters { get; set; }
        public double DailyGasolineRequirementInLiters { get; set; }
        public double DailyDieselRequirementInLiters { get; set; }
        public int DailyCuttingGasCylindersRequired { get; set; }
        public int DailyMedicalOxygenCylindersRequired { get; set; }
        public double RequiredBaseOperationSpaceInSquareMeters { get; set; }
        public string OtherLogisticRequirements { get; set; }
    }
}
