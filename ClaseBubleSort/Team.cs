using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Team
    {
        readonly private string name;
        private int points;

        private Team[] Sort(Team[] teams)
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

        public Team(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public bool EqualsTo(string searchName)
        {
            return name.Equals(searchName, StringComparison.CurrentCultureIgnoreCase);
        }

        public bool IsEqualTo(int newScore)
        {
            return points.Equals(newScore);
        }

        public bool SmallerThan(Team team)
        {
            return points < team.points;
        }

        internal void ChangeWith(int newPoints)
        {
            points = newPoints;
        }

        internal void GetPoints(Team[] rankingSoccer, int position, int addPoints)
        {
            rankingSoccer[position].points += addPoints;
        }
    }
}
