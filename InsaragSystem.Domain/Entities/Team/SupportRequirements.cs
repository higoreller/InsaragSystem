using InsaragSystem.Domain.Validation;
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

            private static void ValidateDomain(string propertyName, double value)
            {
                switch (propertyName)
                {
                    case nameof(TotalEquipmentWeightInTons):
                    case nameof(TotalEquipmentVolumeInCubicMeters):
                    case nameof(DailyGasolineRequirementInLiters):
                    case nameof(DailyDieselRequirementInLiters):
                    case nameof(RequiredBaseOperationSpaceInSquareMeters):
                        DomainExceptionValidation.When(value < 0, $"Invalid {propertyName}. The {propertyName} cannot be negative.");
                        break;
                }
            }

            private static void ValidateDomain(string propertyName, int value)
            {
                switch (propertyName)
                {
                    case nameof(TotalPeopleToTransport):
                    case nameof(TotalDogsToTransport):
                    case nameof(DailyCuttingGasCylindersRequired):
                    case nameof(DailyMedicalOxygenCylindersRequired):
                        DomainExceptionValidation.When(value < 0, $"Invalid {propertyName}. The {propertyName} cannot be negative.");
                        break;
                }
            }

            private static void ValidateDomain(string propertyName, string value)
            {
                switch (propertyName)
                {
                    case nameof(OtherLogisticRequirements):
                        DomainExceptionValidation.When(string.IsNullOrWhiteSpace(value), $"{propertyName} cannot be null or whitespace.");
                        break;
                }
            }

            public Builder WithId(int id)
            {
                ValidateDomain(nameof(Id), id); 
                _supportRequirements.Id = id;
                return this;
            }

            public Builder WithTotalPeopleToTransport(int totalPeopleToTransport)
            {
                ValidateDomain(nameof(TotalPeopleToTransport), totalPeopleToTransport);
                _supportRequirements.TotalPeopleToTransport = totalPeopleToTransport;
                return this;
            }

            public Builder WithTotalDogsToTransport(int totalDogsToTransport)
            {
                ValidateDomain(nameof(TotalDogsToTransport), totalDogsToTransport);
                _supportRequirements.TotalDogsToTransport = totalDogsToTransport;
                return this;
            }

            public Builder WithTotalEquipmentWeightInTons(double totalEquipmentWeightInTons)
            {
                ValidateDomain(nameof(TotalEquipmentWeightInTons), totalEquipmentWeightInTons);
                _supportRequirements.TotalEquipmentWeightInTons = totalEquipmentWeightInTons;
                return this;
            }

            public Builder WithTotalEquipmentVolumeInCubicMeters(double totalEquipmentVolumeInCubicMeters)
            {
                ValidateDomain(nameof(TotalEquipmentVolumeInCubicMeters), totalEquipmentVolumeInCubicMeters);
                _supportRequirements.TotalEquipmentVolumeInCubicMeters = totalEquipmentVolumeInCubicMeters;
                return this;
            }

            public Builder WithDailyGasolineRequirementInLiters(double dailyGasolineRequirementInLiters)
            {
                ValidateDomain(nameof(DailyGasolineRequirementInLiters), dailyGasolineRequirementInLiters);
                _supportRequirements.DailyGasolineRequirementInLiters = dailyGasolineRequirementInLiters;
                return this;
            }

            public Builder WithDailyDieselRequirementInLiters(double dailyDieselRequirementInLiters)
            {
                ValidateDomain(nameof(DailyDieselRequirementInLiters), dailyDieselRequirementInLiters);
                _supportRequirements.DailyDieselRequirementInLiters = dailyDieselRequirementInLiters;
                return this;
            }

            public Builder WithDailyCuttingGasCylindersRequired(int dailyCuttingGasCylindersRequired)
            {
                ValidateDomain(nameof(DailyCuttingGasCylindersRequired), dailyCuttingGasCylindersRequired);
                _supportRequirements.DailyCuttingGasCylindersRequired = dailyCuttingGasCylindersRequired;
                return this;
            }

            public Builder WithDailyMedicalOxygenCylindersRequired(int dailyMedicalOxygenCylindersRequired)
            {
                ValidateDomain(nameof(DailyMedicalOxygenCylindersRequired), dailyMedicalOxygenCylindersRequired);
                _supportRequirements.DailyMedicalOxygenCylindersRequired = dailyMedicalOxygenCylindersRequired;
                return this;
            }

            public Builder WithRequiredBaseOperationSpaceInSquareMeters(double requiredBaseOperationSpaceInSquareMeters)
            {
                ValidateDomain(nameof(RequiredBaseOperationSpaceInSquareMeters), requiredBaseOperationSpaceInSquareMeters);
                _supportRequirements.RequiredBaseOperationSpaceInSquareMeters = requiredBaseOperationSpaceInSquareMeters;
                return this;
            }

            public Builder WithOtherLogisticRequirements(string otherLogisticRequirements)
            {
                ValidateDomain(nameof(OtherLogisticRequirements), otherLogisticRequirements);
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
