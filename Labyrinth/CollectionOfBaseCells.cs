using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    /// <summary>
    /// Contains a collection of, in total 16, base Cells. Each Cell has a unique, binary representation of directions to, which the player, can move, to adjacent Cells.
    /// </summary>
    public class CollectionOfBaseCells
    {
        private static CollectionOfBaseCells? collectionOfBaseCells;
        private readonly List<BaseCell> baseCells = new();
        private CollectionOfBaseCells() { }
        public static CollectionOfBaseCells GetCollectionOfBaseCells()
        {
            collectionOfBaseCells ??= new CollectionOfBaseCells();
            return collectionOfBaseCells;
        }
        public void AddCell(BaseCell baseCell) => baseCells.Add(baseCell);
        public BaseCell GetCell(int index) 
        {
            if (index < 0 || index>= baseCells.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "The BaseCell index, you are searching for does not exist.");
            }
            return baseCells[index];
        }
    }
}
