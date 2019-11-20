using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Ranking
    {
        int teamsCount = 0;
        readonly Team[] teams = new Team[2];

        private Team name;

        public Ranking()
        {
        }

        public Ranking(Team name)
        {
            this.name = name;
        }

        internal void Add(Team team)
        {
            teams[teamsCount] = team;
            teamsCount++;
        }

        internal int FindPositionByTeamName(string teamName)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i].TeamName(teamName))
                {
                    return i + 1;
                }
            }

            return 0;
        }
    }
}
