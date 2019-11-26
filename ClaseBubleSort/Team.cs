using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Team
    {
        readonly private string name;
        private int points;

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
    }
}
