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
            InitializeEmptyBoard(ref inputBoard);
            var revealedBoard = RevealBoard(inputBoard);
            Assert.Equal(2, revealedBoard.GetLength(0));
            Assert.Equal(3, revealedBoard.GetLength(1));
        }

        [Fact]
        public void RevealBoard_Fails_WhenInvalidElementValueExists()
        {
            var inputBoard = new char[2, 3];
            InitializeEmptyBoard(ref inputBoard);

            inputBoard[1, 2] = '1';

            var ex = Assert.Throws<Exception>(() => RevealBoard(inputBoard));
            Assert.Equal("Invalid element value (1). Must be . or * only.", ex.Message);
        }

        private void InitializeEmptyBoard(ref char[,] board)
        {
            for (int col = 0; col < board.GetLength(0); col++)
                for (int row = 0; row < board.GetLength(1); row++)
                    board[col, row] = '.';
        }
    }
}
