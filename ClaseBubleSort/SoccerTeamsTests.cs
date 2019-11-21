using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClaseBubleSort
{
    public class SoccerTeamsTests
    {
        [Fact]
        public void CheckTeamPositionWithOneTeam()
        {
            Ranking ranking = new Ranking();

            ranking.Add(new Team("Team1", 30));

            Assert.Equal(1, ranking.FindPositionByTeamName("Team1"));
        }

        [Fact]
        public void CheckSecondTeamPosition()
        {
            Ranking ranking = new Ranking();

            ranking.Add(new Team("Team1", 30));
            ranking.Add(new Team("Team2", 30));

            Assert.Equal(2, ranking.FindPositionByTeamName("Team2"));
        }

        [Fact]
        public void SearchTeamNameByPosition()
        {
            Ranking ranking = new Ranking();

            ranking.Add(new Team("Team1", 30));
            ranking.Add(new Team("Team2", 28));
            ranking.Add(new Team("Team3", 25));

            Assert.Equal("Team3", ranking.FindTeamByPosition(3));
        }

        [Fact]
        public void GetThePointsOfAGivenTeamName()
        {
            Ranking ranking = new Ranking();

            ranking.Add(new Team("Team1", 30));
            ranking.Add(new Team("Team2", 28));
            ranking.Add(new Team("Team3", 25));

            Assert.Equal(28, ranking.GetPoints("Team2"));
        }
    }
}
