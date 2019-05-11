using System;

namespace MinesweeperLib
{
    public class MinesweeperLib
    {
        public static char[,] RevealBoard(char[,] inputBoard)
        {
            char[,] revealedBoard = inputBoard;

            for (int col = 0; col < revealedBoard.GetLength(0); col++)
                for (int row = 0; row < revealedBoard.GetLength(1); row++)
                {
                    ValidateElement(revealedBoard[col, row]);

                    if (revealedBoard[col, row] == '*')
                        IncrementSurroundings(ref revealedBoard, col, row);
                }

            return revealedBoard;
        }

        private static void ValidateElement(char element)
        {
            if (!".*".Contains(element))
                throw new Exception($"Invalid element value ({element}). Must be . or * only.");
        }

        private static void IncrementSurroundings(ref char[,] board, int col, int row)
        {
            for (int c = col - 1; c <= col + 1; c++)
                for (int r = row - 1; r <= row + 1; r++)
                {
                    if (c != col && r != row)
                    {
                        try
                        {
                            if (board[c, r] != '*')
                                board[c, r] = board[c, r] == '.' ? '1' :
                                    (Convert.ToInt32(board[c, r].ToString()) + 1).ToString().ToCharArray()[0];
                        }
                        catch { };
                    }
                }
        }
    }
}
