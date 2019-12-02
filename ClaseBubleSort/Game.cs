using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Game
    {
        private readonly string teamA;
        private readonly string teamB;
        private readonly int scoreTeamA;
        private readonly int scoreTeamB;
        private readonly int winPoints = 3;
        private readonly int equalPoints = 1;


        public Game(string teamA, int scoreTeamA, int scoreTeamB, string teamB)
        {
            this.teamA = teamA;
            this.teamB = teamB;
            this.scoreTeamA = scoreTeamA;
            this.scoreTeamB = scoreTeamB;
        }

        internal int Points(string name)
        {
            if (name == teamA)
            {
                if (scoreTeamA > scoreTeamB)
                {
                    return winPoints;
                }
            }

            if (name == teamB)
            {
                if (scoreTeamB > scoreTeamA)
                {
                    return winPoints;
                }
            }

            if (scoreTeamA == scoreTeamB)
            {
                return equalPoints;
            }

            return 0;
        }
    }
}
