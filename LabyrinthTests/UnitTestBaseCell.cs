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
            bool expectedOpenNorth = false, expectedOpenSouth = false, expectedOpenWest = false, expectedOpenEast = false;

            // Act
            var baseCell = new BaseCell();
            var actualOpenNorth = baseCell.OpenNorth;
            var actualOpenSouth = baseCell.OpenSouth;
            var actualOpenWest = baseCell.OpenWest;
            var actualOpenEast = baseCell.OpenEast;

            // Assert
            Assert.Equal(expectedOpenNorth, actualOpenNorth);
            Assert.Equal(expectedOpenSouth, actualOpenSouth);
            Assert.Equal(expectedOpenWest, actualOpenWest);
            Assert.Equal(expectedOpenEast, actualOpenEast);

        }

        [Fact]
        public void TestBaseCellAllTrue()
        {
            // Test making a BaseCell with all direktions true.
            // Arrange
            bool expectedOpenNorth = true, expectedOpenSouth = true, expectedOpenWest = true, expectedOpenEast = true;

            // Act
            var baseCell = new BaseCell(openEast: expectedOpenEast,openNorth:expectedOpenNorth,openSouth:expectedOpenSouth,openWest:expectedOpenWest);
            var actualOpenNorth = baseCell.OpenNorth;
            var actualOpenSouth = baseCell.OpenSouth;
            var actualOpenWest = baseCell.OpenWest;
            var actualOpenEast = baseCell.OpenEast;

            // Assert
            Assert.Equal(expectedOpenNorth, actualOpenNorth);
            Assert.Equal(expectedOpenSouth, actualOpenSouth);
            Assert.Equal(expectedOpenWest, actualOpenWest);
            Assert.Equal(expectedOpenEast, actualOpenEast);

        }
        
        // ToDo: Test with different combinations of values to verify no crosstalk.
    }
}
