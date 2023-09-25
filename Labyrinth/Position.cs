﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Position : IPosition
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Position(int x, int y) { X = x; Y = y; }
    }
}
