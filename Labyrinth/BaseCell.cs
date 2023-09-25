using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    public class BaseCell : IBaseCell
    {
        public bool OpenNorth { get; private set; }
        public bool OpenSouth { get; private set; }
        public bool OpenWest { get; private set; }
        public bool OpenEast { get; private set; }
        public BaseCell(bool openNorth = false, bool openSouth = false, bool openWest = false, bool openEast = false)
        {
            OpenNorth = openNorth; OpenSouth = openSouth; OpenWest = openWest; OpenEast = openEast;
        }
    }
}
