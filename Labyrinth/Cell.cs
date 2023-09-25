using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class Cell : ICell
    {
        public int Y { get; private set; }
        public int X { get; private set; }
        public bool OpenNorth { get; private set; }
        public bool OpenSouth { get; private set; }
        public bool OpenEast { get; private set; }
        public bool OpenWest { get; private set; }
        public Cell(IBaseCell cell, IPosition position)
        {
            Y = position.Y;
            X = position.X;
            OpenNorth = cell.OpenNorth;
            OpenSouth = cell.OpenSouth;
            OpenEast = cell.OpenEast;
            OpenWest = cell.OpenWest;
        }
    }
}
