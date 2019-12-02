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

        public bool IsEqualTo(int secondTeamPoints)
        {
            return points.Equals(secondTeamPoints);
        }

        public bool SmallerThan(Team team)
        {
            return points < team.points;
        }

        internal void Update(Game game)
        {
            game.Points(name);
        }
    }
}
