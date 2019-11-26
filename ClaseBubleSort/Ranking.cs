using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Ranking
    {
        private Team[] teams = new Team[0];

        internal void Add(Team team)
        {
            Array.Resize(ref teams, teams.Length + 1);
            teams[teams.Length - 1] = team;
        }

        internal int GetPositionByTeamName(string teamName)
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

        internal Team FindTeamByPosition(int position)
        {
            return teams[position - 1];
        }

        internal Team[] SortRanking(Team[] teams)
        { 
            bool notSorted = true;

            while (notSorted)
            {
                for (int i = 0; i < teams.Length - 1; i++)
                {
                    if (teams[i].SmallerThan(teams[i + 1]))
                    {
                        Team temp = teams[i];
                        teams[i] = teams[i + 1];
                        teams[i + 1] = temp;

                        continue;
                    }
                }

                notSorted = false;
            }

            return teams;
        }

        internal Team[] Update(int newPoints, int position)
        {
            teams[position - 1].ChangeWith(newPoints);
            return SortRanking(teams);
        }
    }
}
