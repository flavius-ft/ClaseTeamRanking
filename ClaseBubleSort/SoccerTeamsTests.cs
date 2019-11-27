using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClaseBubleSort
{
    public class SoccerTeamsTests
    {
        Ranking ranking = new Ranking();

        [Fact]
        public void CheckTeamPositionWithOneTeam()
        {
            ranking.Add(new Team("Team1", 30));

            Assert.Equal(1, ranking.GetPositionByTeamName("Team1"));
        }

        [Fact]
        public void CheckSecondTeamPosition()
        {
            ranking.Add(new Team("Team1", 30));
            ranking.Add(new Team("Team2", 30));

            Assert.Equal(2, ranking.GetPositionByTeamName("Team2"));
        }

        [Fact]
        public void SearchTeamByPosition()
        {
            ranking.Add(new Team("Team1", 30));
            ranking.Add(new Team("Team2", 28));
            ranking.Add(new Team("Team3", 25));
            
            Assert.True(ranking.FindTeamByPosition(2).EqualsTo("Team2"));
        }

        [Fact]
        public void ShowFinalResultAfterTwoTeamsGame()
        {
            Team[] rankingSoccer = new Team[3];
            rankingSoccer[0] = new Team("A", 10);
            rankingSoccer[1] = new Team("B" , 4);
            rankingSoccer[2] = new Team("C", 2);

            rankingSoccer = ranking.UpdateRanking("C", 3, 1, "B");

            Assert.True(ranking.);
        }
    }
}
