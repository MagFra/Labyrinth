using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    /// <summary>
    /// Cells build up the maze and contains the description of which directions is possible to travel.
    /// </summary>
    public class Cell : ICell
    {
        public int Y { get; private set; }
        public int X { get; private set; }
        public bool OpensToNorth { get; private set; }
        public bool OpensToSouth { get; private set; }
        public bool OpensToEast { get; private set; }
        public bool OpensToWest { get; private set; }
        public Cell(IBaseCell baseCell, IPosition position)
        {
            Y = position.Y;
            X = position.X;
            OpensToNorth = baseCell.OpensToNorth;
            OpensToSouth = baseCell.OpensToSouth;
            OpensToEast = baseCell.OpensToEast;
            OpensToWest = baseCell.OpensToWest;
        }
    }
}
