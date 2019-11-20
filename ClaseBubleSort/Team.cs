using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseBubleSort
{
    class Team
    {
        readonly private string name;
        readonly private int points;

        public Team(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public bool TeamName(string searchName)
        {
            string actualName = this.name;

            return actualName == searchName;
        }
    }
}
