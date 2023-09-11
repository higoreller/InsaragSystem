using FluentAssertions;
using InsaragSystem.Domain.Entities.Team;
using System.Diagnostics;

namespace InsaragSystem.Domain.Tests
{
    public class TeamUnitTest1
    {
        [Fact(DisplayName = "Create Team With Valid State")]
        public void CreateTeam_WithValidParameters_ResultObjectValidState()
        {
            var mockContactDetails = new ContactDetails.Builder()
                .WithContact1NameOrTitle("Higor Eller")
                .WithContact1Email("higoreller29@gmail.com").Build();
            var mockSupportRequirements = new SupportRequirements.Builder()
                .WithDailyDieselRequirementInLiters(5)
                .WithTotalPeopleToTransport(40).Build();
            var mockTeamDetails = new TeamDetails.Builder()
                .WithId(1)
                .WithName("BRA-13")
                .WithOlympicCountryCode("BRA").Build();
            
            Action action = () => new Team(mockContactDetails, mockSupportRequirements, mockTeamDetails);
            action.Should().NotBeNull();
            action.Should().NotThrow<InsaragSystem.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact(DisplayName = "Validate Team State")]
        public void CreateTeam_ValidateTeamState_ShouldHaveExpectedValues()
        {
            var mockContactDetails = new ContactDetails.Builder()
                .WithContact1NameOrTitle("Higor Eller")
                .WithContact1Email("higoreller29@gmail.com").Build();

            var mockSupportRequirements = new SupportRequirements.Builder()
                .WithDailyDieselRequirementInLiters(5)
                .WithTotalPeopleToTransport(40).Build();

            var mockTeamDetails = new TeamDetails.Builder()
                .WithId(1)
                .WithName("BRA-13")
                .WithOlympicCountryCode("BRA").Build();

            var createdTeam = new Team(mockContactDetails, mockSupportRequirements, mockTeamDetails);

            createdTeam.ContactDetails.Contact1NameOrTitle.Should().Be("Higor Eller");
            createdTeam.ContactDetails.Contact1Email.Should().Be("higoreller29@gmail.com");
            createdTeam.TeamDetails.Name.Should().Be("BRA-13");
            createdTeam.TeamDetails.EstimatedArrivalDate.Should().Be(DateOnly.MinValue);

        }

        [Fact(DisplayName = "Validate Error Message")]
        public void CreateTeam_ValidateErrorMessage_ShouldHaveExpectedValues()
        {

            Action mockTeamDetails = () => new TeamDetails.Builder()
                .WithId(1)
                .WithName("BRA-13, More than 100 characters, More than 100 characters, " +
                "More than 100 characters, More than 100 characters, More than 100 characters, " +
                "More than 100 characters, More than 100 characters, More than 100 characters, " +
                "More than 100 characters, More than 100 characters, ")
                .WithOlympicCountryCode("BRA").Build();

            mockTeamDetails.Should().Throw<InsaragSystem.Domain.Validation.DomainExceptionValidation>().WithMessage("Name cannot be more than 100 characters.");
        }
    }
}