using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class UpdateRanking
    {
        private Team[] teams;

        public UpdateRanking(Team[] teams)
        {
            this.teams = teams;
        }

        public Team[] NewRanking()
        {
            int count = 1;
            while (count != 0)
            {
                if (teams == null)
                {
                    Console.WriteLine("-1");
                    break;
                }

                count = 0;
                for (int i = 0; i < teams.Length - 1; i++)
                {
                    if (teams[i].SmallerThan(teams[i + 1]))
                    {
                        Team temp = teams[i];
                        teams[i] = teams[i + 1];
                        teams[i + 1] = temp;
                        count++;
                    }
                }
            }

            return teams;
        }
    }
}
