using System;
using System.Collections.Generic;
using System.IO;
using InsaragSystem.Domain.Entities;
using InsaragSystem.Domain.Entities.Team;

public class TeamLoader
{
    public List<Team> LoadTeams(string filePath)
    {
        List<Team> teams = new List<Team>();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var fields = line.Split(';');

            // Construção de ContactDetails
            var contactDetailsBuilder = new ContactDetails.Builder()
                .WithContact1NameOrTitle(fields[0])
                .WithContact1MobilePhoneNumber(fields[1])
                .WithContact1SatellitePhoneNumber(fields[2])
                .WithContact1Email(fields[3])
                                .WithContact2NameOrTitle(fields[4])
                .WithContact2MobilePhoneNumber(fields[5])
                .WithContact2SatellitePhoneNumber(fields[6])
                .WithContact2Email(fields[7])
                .WithBaseOperationLocation(fields[8])
                .WithRadioFrequencyInMHz(fields[9])
                .WithWorkSiteGpsCoordinates(new GpsCoordinates(double.Parse(fields[10]), double.Parse(fields[11])));
            var contactDetails = contactDetailsBuilder.Build();

            var supportRequirementsBuilder = new SupportRequirements.Builder()
                .WithId(int.Parse(fields[12]))
                .WithTotalPeopleToTransport(int.Parse(fields[13]))
                .WithTotalDogsToTransport(int.Parse(fields[14]))
                .WithTotalEquipmentWeightInTons(double.Parse(fields[15]))
                .WithTotalEquipmentVolumeInCubicMeters(double.Parse(fields[16]))
                .WithDailyGasolineRequirementInLiters(double.Parse(fields[17]))
                .WithDailyDieselRequirementInLiters(double.Parse(fields[18]))
                .WithDailyCuttingGasCylindersRequired(int.Parse(fields[19]))
                .WithDailyMedicalOxygenCylindersRequired(int.Parse(fields[20]))
                .WithRequiredBaseOperationSpaceInSquareMeters(double.Parse(fields[21]))
                .WithOtherLogisticRequirements(fields[22]);
            var supportRequirements = supportRequirementsBuilder.Build();

            var teamDetailsBuilder = new TeamDetails.Builder()
                .WithId(int.Parse(fields[23]))
                .WithOlympicCountryCode(fields[24])
                .WithName(fields[25])
                .WithCountryOfOrigin(fields[26])
                .WithTotalDeployedPeople(int.Parse(fields[27]))
                .WithTotalDeployedDogs(int.Parse(fields[28]))
                .WithResponseType(fields[29])
                .WithInsaragClassification(fields[30])
                .WithHasTechnicalSearchCapability(bool.Parse(fields[31]))
                .WithHasCanineSearchCapability(bool.Parse(fields[32]))
                .WithHasRescueCapability(bool.Parse(fields[33]))
                .WithHasMedicalCapability(bool.Parse(fields[34]))
                .WithHasHazardousMaterialDetectionCapability(bool.Parse(fields[35]))
                .WithNumberOfStructuralEngineers(int.Parse(fields[36]))
                .WithHasProvisionalOSOCCCapability(bool.Parse(fields[37]))
                .WithCanSupportUC(bool.Parse(fields[38]))
                .WithOtherCapabilities(fields[39])
                .WithDaysOfWaterAutonomy(int.Parse(fields[40]))
                .WithDaysOfFoodAutonomy(int.Parse(fields[41]))
                .WithEstimatedArrivalDateTime(DateTime.Parse(fields[42]))
                .WithArrivalPoint(fields[43])
                .WithAircraftType(fields[44]);
            var teamDetails = teamDetailsBuilder.Build();

            var team = new Team(contactDetails, supportRequirements, teamDetails);
            teams.Add(team);
        }

        return teams;
    }
}




