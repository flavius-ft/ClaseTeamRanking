using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Ranking
    {
        int teamsCount = 0;
        readonly Team[] teams = new Team[2];

        internal void Add(Team team)
        {
            teams[teamsCount] = team;
            teamsCount++;
        }

        internal int Position(string teamName)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i].Equals(teamName))
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
