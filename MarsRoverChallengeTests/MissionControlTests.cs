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
        public void ShouldReturn13N()
        {
            marsMission = new MissionControl((5,5), (1,2), MarsRoverChallenge.BaseModels.EInstructions.Directions.N, "LMLMLMLMM");

            marsMission.CurrentLocation().Should().Be("(1, 3) N");
        }

         [Test]
        public void ShouldReturn51E()
        {
            marsMission = new MissionControl((5, 5), (3, 3), MarsRoverChallenge.BaseModels.EInstructions.Directions.E, " MMRMMRMRRM");

            marsMission.CurrentLocation().Should().Be("(5, 1) E");
        }
    }
}