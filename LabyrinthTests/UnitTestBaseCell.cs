using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthTests
{
    /// <summary>
    /// Class to UnitTest the BaseCell class.
    /// </summary>
    public class UnitTestBaseCell
    {
        [Fact]
        public void TestBaseCellEmpty()
        {
            // Test making a BaseCell with empty constructor.
            // Arrange
            bool expectedOpensToNorth = false, expectedOpensToSouth = false, expectedOpensToWest = false, expectedOpensToEast = false;

            // Act
            var baseCell = new BaseCell();
            var actualOpensToNorth = baseCell.OpensToNorth;
            var actualOpensToSouth = baseCell.OpensToSouth;
            var actualOpensToWest = baseCell.OpensToWest;
            var actualOpensToEast = baseCell.OpensToEast;

            // Assert
            Assert.Equal(expectedOpensToNorth, actualOpensToNorth);
            Assert.Equal(expectedOpensToSouth, actualOpensToSouth);
            Assert.Equal(expectedOpensToWest, actualOpensToWest);
            Assert.Equal(expectedOpensToEast, actualOpensToEast);

        }

        [Fact]
        public void TestBaseCellAllTrue()
        {
            // Test making a BaseCell with all direktions true.
            // Arrange
            bool expectedOpensToNorth = true, expectedOpensToSouth = true, expectedOpensToWest = true, expectedOpensToEast = true;

            // Act
            var baseCell = new BaseCell(opensToEast: expectedOpensToEast,opensToNorth:expectedOpensToNorth,opensToSouth:expectedOpensToSouth,opensToWest:expectedOpensToWest);
            var actualOpensToNorth = baseCell.OpensToNorth;
            var actualOpensToSouth = baseCell.OpensToSouth;
            var actualOpensToWest = baseCell.OpensToWest;
            var actualOpensToEast = baseCell.OpensToEast;

            // Assert
            Assert.Equal(expectedOpensToNorth, actualOpensToNorth);
            Assert.Equal(expectedOpensToSouth, actualOpensToSouth);
            Assert.Equal(expectedOpensToWest, actualOpensToWest);
            Assert.Equal(expectedOpensToEast, actualOpensToEast);

        }
        
        // ToDo: Test with different combinations of values to verify no crosstalk.
    }
}
