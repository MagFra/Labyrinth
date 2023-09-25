using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthTests
{
    public class UnitTestInitializeCollectionsOfBaseCells
    {
        [Fact]
        public void Initialize()
        {
            // Arrange
            int expected = 16;
            InitializeCollectionsOfBaseCells initializeCollectionsOfBaseCells = new InitializeCollectionsOfBaseCells();
            CollectionOfBaseCells collectionOfBaseCells = CollectionOfBaseCells.GetCollectionOfBaseCells();

            // Act
            initializeCollectionsOfBaseCells.Initialize();
            int actual = collectionOfBaseCells.Count;

            // Assert
            Assert.Equal(expected, actual);

        }
}
}
