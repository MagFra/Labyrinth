using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    /// <summary>
    /// Creates 16 predefined BaseCells. And store them in the CollectionOfBaseCells.
    /// </summary>
    public class InitializeCollectionsOfBaseCells
    {
        private CollectionOfBaseCells? collectionOfBaseCells = null!;

        public void Initialize()
        {
            collectionOfBaseCells = CollectionOfBaseCells.GetCollectionOfBaseCells();
            if (collectionOfBaseCells.Count == 16) { return; }
            collectionOfBaseCells.Clear();
            bool opensToNorth, opensToSouth, opensToWest, opensToEast;
            for (int i = 0; i < 16; i++)
            {
                opensToNorth = (i & 1) == 1;
                opensToEast = (i & 2) == 2;
                opensToSouth = (i & 4) == 4;
                opensToWest = (i & 8) == 8;
                collectionOfBaseCells.AddCell(new BaseCell(opensToNorth:opensToNorth,opensToSouth:opensToSouth,opensToWest:opensToWest,opensToEast:opensToEast));
            }
        }
    }
}
