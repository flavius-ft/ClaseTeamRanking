using System;

namespace ClaseBubleSort
{
    class Program
    {
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
    }
}
