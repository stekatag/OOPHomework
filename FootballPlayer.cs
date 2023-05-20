﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHomework
{
    public abstract class FootballPlayer : Person
    {
        public int Number { get; set; }
        public double Height { get; set; }

        public FootballPlayer(string name, int age, int number, double height)
            : base(name, age)
        {
            this.Number = number;
            this.Height = height;
        }
    }
}
