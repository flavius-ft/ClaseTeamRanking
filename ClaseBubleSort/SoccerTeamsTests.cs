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
            Team a = new Team("A", 10);
            Team b = new Team("B", 4);
            Team c = new Team("C", 2);

            ranking.Add(a);
            ranking.Add(b);
            ranking.Add(c);

            ranking.Update(new Game("C", 3, 1, "B"));

            Assert.True(ranking.FindTeamByPosition(2).EqualsTo("C"));
        }

        [Fact]
        public void ShowFinalRanking()
        {
            Team a = new Team("A", 10);
            Team b = new Team("B", 4);
            Team c = new Team("C", 2);

            ranking.Add(a);
            ranking.Add(b);
            ranking.Add(c);

            ranking.Update(new Game("C", 3, 1, "B"));

            Assert.True(ranking.FindTeamByPosition(2).EqualsTo("C"));
        }
    }
}
