﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Ranking
    {
        Team[] teams = new Team[0];

        internal void Add(Team team)
        {
            Array.Resize(ref teams, teams.Length + 1);
            teams[teams.Length - 1] = team;
        }

        internal int FindPositionByTeamName(string teamName)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i].EqualsTo(teamName))
                {
                    return i + 1;
                }
            }

            return 0;
        }

        internal string FindTeamByPosition(int position)
        {
            return teams[position - 1].SearchTeamName();
        }

        internal int GetPoints(string teamName)
        {
            for (int i = 0; i < teams.Length; i++)
            {
                if (teams[i].EqualsTo(teamName))
                {
                    return teams[i].Points();
                }
            }

            return 0;
        }
    }
}
