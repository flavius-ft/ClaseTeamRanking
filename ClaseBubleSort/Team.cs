﻿using System;
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

        public bool EqualsTo(string searchName)
        {
            return name.Equals(searchName, StringComparison.CurrentCultureIgnoreCase);
        }

        internal bool SmallerThan(Team team)
        {
            return points < team.points;
        }
    }
}
