using System.Diagnostics;

namespace LabyrinthTests
{
    /// <summary>
    /// Test class to verify that CollectionOfBaseCells is working as expected.
    /// </summary>
    public class UnitTestCollectionOfBaseCells
    {
        [Fact]
        public void TestGetCollectionOfBaseCells()
        {
            // Arrange
            var collectionOfBaseCells = CollectionOfBaseCells.GetCollectionOfBaseCells();

            // Act

            // Assert
            Assert.True(condition: collectionOfBaseCells is not null and CollectionOfBaseCells);

        }

        [Fact]
        public void AddGetCell()
        {
            // Tests both adding and getting a base Cell.

            // Arrange
            var expectedCell = new BaseCell();
            var collectionOfBaseCells = CollectionOfBaseCells.GetCollectionOfBaseCells();
            collectionOfBaseCells.AddCell(expectedCell);

            // Act
            var actualCell = collectionOfBaseCells.GetCell(0);

            // Assert
            Assert.Equal(expectedCell, actualCell);

        }

        [Fact]
        public void OutOfRange()
        {
            // Arrange
            var collectionOfBaseCells = CollectionOfBaseCells.GetCollectionOfBaseCells();

            // Act

            // Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => collectionOfBaseCells.GetCell(5));
            Assert.Equal("The BaseCell index, you are searching for does not exist. (Parameter 'index')", ex.Message);

        }
}
}