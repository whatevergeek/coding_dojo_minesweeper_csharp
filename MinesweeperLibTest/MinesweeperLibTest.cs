using System;
using Xunit;
using static MinesweeperLib.MinesweeperLib;

namespace MinesweeperLibTest
{
    public class MinesweeperLibTest
    {
        [Fact]
        public void RevealBoard_Succeeds_WhenDimensionsAreExpected()
        {
            var inputBoard = new char[2, 3];
            var revealedBoard = RevealBoard(inputBoard);
            Assert.Equal(2, revealedBoard.GetLength(0));
            Assert.Equal(3, revealedBoard.GetLength(1));
        }
    }
}
