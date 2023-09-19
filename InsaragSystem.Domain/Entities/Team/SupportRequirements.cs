using InsaragSystem.Domain.Validation;
using InsaragSystem.Domain.Validations.TeamValidations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Entities.Team
{
    public sealed class SupportRequirements : TeamBase
    {
        public int TotalPeopleToTransport { get; private set; }
        public int TotalDogsToTransport { get; private set; }
        public double TotalEquipmentWeightInTons { get; private set; }
        public double TotalEquipmentVolumeInCubicMeters { get; private set; }
        public double DailyGasolineRequirementInLiters { get; private set; }
        public double DailyDieselRequirementInLiters { get; private set; }
        public int DailyCuttingGasCylindersRequired { get; private set; }
        public int DailyMedicalOxygenCylindersRequired { get; private set; }
        public double RequiredBaseOperationSpaceInSquareMeters { get; private set; }
        public string OtherLogisticRequirements { get; private set; }

        private SupportRequirements() { }

        public void Update(
            int id,
            int totalPeopleToTransport,
            int totalDogsToTransport,
            double totalEquipmentWeightInTons,
            double totalEquipmentVolumeInCubicMeters,
            double dailyGasolineRequirementInLiters,
            double dailyDieselRequirementInLiters,
            int dailyCuttingGasCylindersRequired,
            int dailyMedicalOxygenCylindersRequired,
            double requiredBaseOperationSpaceInSquareMeters,
            string otherLogisticRequirements)
        {
            var builder = new Builder()
                .WithId(id)
                .WithTotalPeopleToTransport(totalPeopleToTransport)
                .WithTotalDogsToTransport(totalDogsToTransport)
                .WithTotalEquipmentWeightInTons(totalEquipmentWeightInTons)
                .WithTotalEquipmentVolumeInCubicMeters(totalEquipmentVolumeInCubicMeters)
                .WithDailyGasolineRequirementInLiters(dailyGasolineRequirementInLiters)
                .WithDailyDieselRequirementInLiters(dailyDieselRequirementInLiters)
                .WithDailyCuttingGasCylindersRequired(dailyCuttingGasCylindersRequired)
                .WithDailyMedicalOxygenCylindersRequired(dailyMedicalOxygenCylindersRequired)
                .WithRequiredBaseOperationSpaceInSquareMeters(requiredBaseOperationSpaceInSquareMeters)
                .WithOtherLogisticRequirements(otherLogisticRequirements);

            var updatedRequirements = builder.Build();

            Id = updatedRequirements.Id;
            TotalPeopleToTransport = updatedRequirements.TotalPeopleToTransport;
            TotalDogsToTransport = updatedRequirements.TotalDogsToTransport;
            TotalEquipmentWeightInTons = updatedRequirements.TotalEquipmentWeightInTons;
            TotalEquipmentVolumeInCubicMeters = updatedRequirements.TotalEquipmentVolumeInCubicMeters;
            DailyGasolineRequirementInLiters = updatedRequirements.DailyGasolineRequirementInLiters;
            DailyDieselRequirementInLiters = updatedRequirements.DailyDieselRequirementInLiters;
            DailyCuttingGasCylindersRequired = updatedRequirements.DailyCuttingGasCylindersRequired;
            DailyMedicalOxygenCylindersRequired = updatedRequirements.DailyMedicalOxygenCylindersRequired;
            RequiredBaseOperationSpaceInSquareMeters = updatedRequirements.RequiredBaseOperationSpaceInSquareMeters;
            OtherLogisticRequirements = updatedRequirements.OtherLogisticRequirements;
        }

        public class Builder
        {
            private readonly SupportRequirements _supportRequirements = new();
                      

            public Builder WithId(int id)
            {
                SupportRequirementsValidation.ValidateId(id);
                _supportRequirements.Id = id;
                return this;
            }

            public Builder WithTotalPeopleToTransport(int totalPeopleToTransport)
            {
                SupportRequirementsValidation.ValidateTotalPeopleToTransport(totalPeopleToTransport);
                _supportRequirements.TotalPeopleToTransport = totalPeopleToTransport;
                return this;
            }

            public Builder WithTotalDogsToTransport(int totalDogsToTransport)
            {
                SupportRequirementsValidation.ValidateTotalDogsToTransport(totalDogsToTransport);
                _supportRequirements.TotalDogsToTransport = totalDogsToTransport;
                return this;
            }

            public Builder WithTotalEquipmentWeightInTons(double totalEquipmentWeightInTons)
            {
                SupportRequirementsValidation.ValidateTotalEquipmentWeightInTons(totalEquipmentWeightInTons);
                _supportRequirements.TotalEquipmentWeightInTons = totalEquipmentWeightInTons;
                return this;
            }

            public Builder WithTotalEquipmentVolumeInCubicMeters(double totalEquipmentVolumeInCubicMeters)
            {
                SupportRequirementsValidation.ValidateTotalEquipmentVolumeInCubicMeters(totalEquipmentVolumeInCubicMeters);
                _supportRequirements.TotalEquipmentVolumeInCubicMeters = totalEquipmentVolumeInCubicMeters;
                return this;
            }

            public Builder WithDailyGasolineRequirementInLiters(double dailyGasolineRequirementInLiters)
            {
                SupportRequirementsValidation.ValidateDailyGasolineRequirementInLiters(dailyGasolineRequirementInLiters);
                _supportRequirements.DailyGasolineRequirementInLiters = dailyGasolineRequirementInLiters;
                return this;
            }

            public Builder WithDailyDieselRequirementInLiters(double dailyDieselRequirementInLiters)
            {
                SupportRequirementsValidation.ValidateDailyDieselRequirementInLiters(dailyDieselRequirementInLiters);
                _supportRequirements.DailyDieselRequirementInLiters = dailyDieselRequirementInLiters;
                return this;
            }

            public Builder WithDailyCuttingGasCylindersRequired(int dailyCuttingGasCylindersRequired)
            {
                SupportRequirementsValidation.ValidateDailyCuttingGasCylindersRequired(dailyCuttingGasCylindersRequired);
                _supportRequirements.DailyCuttingGasCylindersRequired = dailyCuttingGasCylindersRequired;
                return this;
            }

            public Builder WithDailyMedicalOxygenCylindersRequired(int dailyMedicalOxygenCylindersRequired)
            {
                SupportRequirementsValidation.ValidateDailyMedicalOxygenCylindersRequired(dailyMedicalOxygenCylindersRequired);
                _supportRequirements.DailyMedicalOxygenCylindersRequired = dailyMedicalOxygenCylindersRequired;
                return this;
            }

            public Builder WithRequiredBaseOperationSpaceInSquareMeters(double requiredBaseOperationSpaceInSquareMeters)
            {
                SupportRequirementsValidation.ValidateRequiredBaseOperationSpaceInSquareMeters(requiredBaseOperationSpaceInSquareMeters);
                _supportRequirements.RequiredBaseOperationSpaceInSquareMeters = requiredBaseOperationSpaceInSquareMeters;
                return this;
            }

            public Builder WithOtherLogisticRequirements(string otherLogisticRequirements)
            {
                SupportRequirementsValidation.ValidateOtherLogisticRequirements(otherLogisticRequirements);
                _supportRequirements.OtherLogisticRequirements = otherLogisticRequirements;
                return this;
            }

            public SupportRequirements Build()
            {
                return _supportRequirements;
            }
        }
    }
}
