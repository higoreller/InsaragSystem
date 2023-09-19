using InsaragSystem.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaragSystem.Domain.Validations.TeamValidations
{
    public static class SupportRequirementsValidation
    {
        public const double MaxEquipmentWeight = 100.0;
        public const int MaxLogisticRequirementsLength = 500;

        public static void ValidateId(int id)
        {
            DomainExceptionValidation.When(id < 0, "Id cannot be negative.");
        }

        public static void ValidateTotalPeopleToTransport(int totalPeopleToTransport)
        {
            DomainExceptionValidation.When(totalPeopleToTransport < 0, "Total people to transport cannot be negative.");
        }

        public static void ValidateTotalDogsToTransport(int totalDogsToTransport)
        {
            DomainExceptionValidation.When(totalDogsToTransport < 0, "Total dogs to transport cannot be negative.");
        }

        public static void ValidateTotalEquipmentWeightInTons(double totalEquipmentWeightInTons)
        {
            DomainExceptionValidation.When(totalEquipmentWeightInTons < 0, "Total equipment weight cannot be negative.");
            DomainExceptionValidation.When(totalEquipmentWeightInTons > MaxEquipmentWeight, $"Total equipment weight cannot be more than {MaxEquipmentWeight} tons.");
        }

        public static void ValidateTotalEquipmentVolumeInCubicMeters(double totalEquipmentVolumeInCubicMeters)
        {
            DomainExceptionValidation.When(totalEquipmentVolumeInCubicMeters < 0, "Total equipment volume cannot be negative.");
        }

        public static void ValidateDailyGasolineRequirementInLiters(double dailyGasolineRequirementInLiters)
        {
            DomainExceptionValidation.When(dailyGasolineRequirementInLiters < 0, "Daily gasoline requirement cannot be negative.");
        }

        public static void ValidateDailyDieselRequirementInLiters(double dailyDieselRequirementInLiters)
        {
            DomainExceptionValidation.When(dailyDieselRequirementInLiters < 0, "Daily diesel requirement cannot be negative.");
        }

        public static void ValidateDailyCuttingGasCylindersRequired(int dailyCuttingGasCylindersRequired)
        {
            DomainExceptionValidation.When(dailyCuttingGasCylindersRequired < 0, "Daily cutting gas cylinders required cannot be negative.");
        }

        public static void ValidateDailyMedicalOxygenCylindersRequired(int dailyMedicalOxygenCylindersRequired)
        {
            DomainExceptionValidation.When(dailyMedicalOxygenCylindersRequired < 0, "Daily medical oxygen cylinders required cannot be negative.");
        }

        public static void ValidateRequiredBaseOperationSpaceInSquareMeters(double requiredBaseOperationSpaceInSquareMeters)
        {
            DomainExceptionValidation.When(requiredBaseOperationSpaceInSquareMeters < 0, "Required base operation space cannot be negative.");
        }

        public static void ValidateOtherLogisticRequirements(string otherLogisticRequirements)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(otherLogisticRequirements), "Other logistic requirements cannot be null or whitespace.");
            DomainExceptionValidation.When(otherLogisticRequirements.Length > MaxLogisticRequirementsLength, $"Other logistic requirements cannot be more than {MaxLogisticRequirementsLength} characters.");
        }
    }
}
