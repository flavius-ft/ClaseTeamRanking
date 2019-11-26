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
        public void SortRankingAndCompareWithASortedOne()
        {
            Team[] randomRanking = new Team[3];
            randomRanking[0] = new Team("Team1", 20);
            randomRanking[1] = new Team("Team2", 25);
            randomRanking[2] = new Team("Team3", 30);

            Team[] sortedRanking = new Team[3];
            sortedRanking[0] = new Team("Team3", 30);
            sortedRanking[1] = new Team("Team2", 25);
            sortedRanking[2] = new Team("Team1", 20);

            Assert.Equal(sortedRanking, ranking.SortRanking(randomRanking));
        }

        [Fact]
        public void ShowFinalResultOfTwoTeamsGame()
        {
            Team[] twoTeamsGame = new Team[2];
            twoTeamsGame[0] = new Team("A", 2);
            twoTeamsGame[1] = new Team("B" , 4);
            
        }
    }
}
