using FluentAssertions;
using MarsRoverChallenge;

namespace MarsRoverChallengeTests
{
    public class MissionControlTests
    {
        private MissionControl marsMission;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ShouldReturnCoordinates()
        {
            marsMission = new MissionControl((1,2), MarsRoverChallenge.BaseModels.EInstructions.Directions.N, (5,5), "LMLMLMLMM");

            marsMission.CurrentLocation().Should().Be((1, 2));
        }
    }
}