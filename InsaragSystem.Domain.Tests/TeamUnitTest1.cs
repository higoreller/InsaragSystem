using FluentAssertions;
using InsaragSystem.Domain.Entities.Team;

namespace InsaragSystem.Domain.Tests
{
    public class TeamUnitTest1
    {
        [Fact]
        public void CreateTeam_WithValidParameters_ResultObjectValidState()
        {
            var mockContactDetails = new ContactDetails.Builder()
                .WithContact1NameOrTitle("Higor Eller")
                .WithContact1Email("higoreller29@gmail.com").Build();
            var mockSupportRequirements = new SupportRequirements.Builder()
                .WithDailyDieselRequirementInLiters(5)
                .WithTotalPeopleToTransport(40).Build();
            var mockTeamDetails = new TeamDetails.Builder()
                .WithName("BRA-13")
                .WithOlympicCountryCode("BRA").Build();
            
            Action action = () => new Team(mockContactDetails, mockSupportRequirements, mockTeamDetails);
            action.Should().NotBeNull();
            action.Should().Throw<InsaragSystem.Domain.Validation.DomainExceptionValidation>();
        }
    }
}