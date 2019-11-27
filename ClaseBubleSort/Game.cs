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

        public Game(string teamA, int scoreTeamA, int scoreTeamB, string teamB)
        {
            this.teamA = teamA;
            this.teamB = teamB;
            this.scoreTeamA = scoreTeamA;
            this.scoreTeamB = scoreTeamB;
        }

        internal int Points(string name)
        {
            throw new NotImplementedException();
        }
    }
}
