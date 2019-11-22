using Xunit;

namespace ClaseBubleSort
{
    public class TeamTests
    {
        [Fact]
        public void TeamEqualsToAStringWhenItHasTheSameName()
        {
            var team = new Team("a", 1);
            Assert.True(team.EqualsTo("a"));
        }

        [Fact]
        public void TeamEqualsToIsCaseInsensitive()
        {
            var team = new Team("a", 1);
            Assert.True(team.EqualsTo("A"));
        }

        [Fact]
        public void TeamIsNOTEqualToAStringWhenItHasADifferentName()
        {
            var team = new Team("a", 1);
            Assert.False(team.EqualsTo("B"));
        }
    }
}
