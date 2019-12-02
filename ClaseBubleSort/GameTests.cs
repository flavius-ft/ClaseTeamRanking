using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClaseBubleSort
{
    public class GameTests
    {
        [Fact]
        public void GetMaxPointsWhenFirstTeamGetMoreGoals()
        {
            Game game = new Game("teamA", 2, 1, "teamB");

            Assert.Equal(3, game.Points("teamA"));
        }

        [Fact]
        public void GetEqualPointsWhenBothTeamsHaveSameScore()
        {
            Game game = new Game("teamA", 1, 1, "teamB");

            Assert.Equal(1, game.Points("teamA"));
        }

        [Fact]
        public void GetZeroPointsWhenTheTeamHaveLessGoals()
        {
            Game game = new Game("teamA", 1, 0, "teamB");

            Assert.Equal(0, game.Points("teamB"));
        }
    }
}
