using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Labyrinth
{
    /// <summary>
    /// A Base Cell has two purposes.
    /// 1. To act as "buffer" with "translated" descriptions of the layout of the cells.
    /// 2. To work as my "pre verified" datablocks for setting new cells.
    /// </summary>
    public class BaseCell : IBaseCell
    {
        public bool OpensToNorth { get; private set; }
        public bool OpensToSouth { get; private set; }
        public bool OpensToWest { get; private set; }
        public bool OpensToEast { get; private set; }
        public BaseCell(bool opensToNorth = false, bool opensToSouth = false, bool opensToWest = false, bool opensToEast = false)
        {
            OpensToNorth = opensToNorth; OpensToSouth = opensToSouth; OpensToWest = opensToWest; OpensToEast = opensToEast;
        }
    }
}
