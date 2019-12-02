using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Ranking
    {
        private Team[] teams = new Team[0];

        const int winPoints = 3;
        const int equalPoints = 1;

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

        //internal void Update(string firstTeam, int firstTeamGoals, int secodTeamGoals, string secondTeam)
        //{
        //    if (firstTeamGoals > secodTeamGoals)
        //    {
        //        teams[GetPositionByTeamName(firstTeam) - 1].Give(winPoints);
        //    }
        //    else if (firstTeamGoals == secodTeamGoals)
        //    {
        //        teams[GetPositionByTeamName(firstTeam) - 1].Give(equalPoints);
        //        teams[GetPositionByTeamName(secondTeam) - 1].Give(equalPoints);
        //    }
        //}

        internal void Update(Game game)
        {
            foreach (var team in teams)
            {
                team.Update(game);
            }
           
        }
    }
}
