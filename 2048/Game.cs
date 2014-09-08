using _2048.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class Game
    {
        private const int _boardSize = 4;
        private Tile[,] board;

        public Tile[,] Board
        {
            get { return board; }
            set { board = value; }
        }

        public Game()
        {
            Board = new Tile[_boardSize, _boardSize];
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    board[i, j] = new Tile();
                }
            }

            board[0, 0].Value = 1;
            board[1, 0].Value = 2;
            board[2, 0].Value = 3;
            board[3, 0].Value = 4;
        }

        public void Run()
        {
            if (IsGameOver())
            {
                throw new Exception("Game Over!!!");
            }

            for (int i = 0; i < 1; i++)
            {
                MoveUp();
            }
        }

        private bool IsGameOver()
        {
            for (int row = 0; row < _boardSize; row++)
            {
                for (int col = 0; col < _boardSize; col++)
                {
                    if (board[row, col].Value == 0 || IsPossibleMove(row, col))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsPossibleMove(int row, int col)
        {
            var currentTile = board[row, col];

            bool left = col == 0 ? false : board[row, col - 1].Value == currentTile.Value;
            bool right = col == _boardSize - 1 ? false : board[row, col + 1].Value == currentTile.Value;
            bool down = row == _boardSize - 1 ? false : board[row + 1, col].Value == currentTile.Value;
            bool up = row == 0? false : board[row - 1, col].Value == currentTile.Value;

            return left || right || down || up;
        }

        private void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    MoveRight();
                    break;
                case Direction.Left:
                    MoveLeft();
                    break;
                case Direction.Down:
                    MoveDown();
                    break;
                case Direction.Up:
                    MoveUp();
                    break;
                default:
                    break;
            }
        }

        //private Tile GetNext(int row, int col)
        //{
        //    return board[row + 1, col];
        //}

        private void PutNewElement()
        {
            var emptyTiles = new List<Tile>();
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    if (board[i,j].Value==0)
                    {
                        emptyTiles.Add(board[i, j]);
                    }
                }
            }

            emptyTiles.
        }


        private void MoveUp()
        {
            Func<int, int, Tile> getNext = (row, col) => board[row - 1, col];

            for (int col = 0; col < _boardSize; col++)
            {
                for (int row = 0; row < _boardSize; row++)
                {
                    int tmpRow = row;

                    var currentTile = board[tmpRow, col];
                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    while (tmpRow > 0 && getNext(tmpRow, col).Value == 0)
                    {
                        getNext(tmpRow, col).Value = currentTile.Value;
                        currentTile.Value = 0;
                        tmpRow--;
                    }

                    if (tmpRow > 0 && getNext(tmpRow, col).Value == currentTile.Value)
                    {
                        getNext(tmpRow, col).Value *= 2;
                        currentTile.Value = 0;
                    }
                }
            }
        }

        private void MoveDown()
        {
            Func<int, int, Tile> getNext = (row, col) => board[row + 1, col];

            for (int col = 0; col < _boardSize; col++)
            {
                for (int row = _boardSize - 2; row >= 0; row--)
                {
                    int tmpRow = row;

                    var currentTile = board[tmpRow, col];
                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    while (tmpRow < _boardSize - 1 && getNext(tmpRow, col).Value == 0)
                    {
                        getNext(tmpRow, col).Value = currentTile.Value;
                        currentTile.Value = 0;
                        tmpRow++;
                    }

                    if (tmpRow < _boardSize - 1 && getNext(tmpRow, col).Value == currentTile.Value)
                    {
                        getNext(tmpRow, col).Value *= 2;
                        currentTile.Value = 0;
                    }
                }
            }
        }

        private void MoveLeft()
        {
            Func<int, int, Tile> getNext = (row, col) => board[row, col - 1];

            for (int row = 0; row < _boardSize; row++)
            {
                for (int col = 0; col < _boardSize; col++)
                {
                    int tmpCol = col;
                    var currentTile = board[row, tmpCol];

                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    while (tmpCol > 0 && getNext(row, tmpCol).Value == 0)
                    {
                        getNext(row, tmpCol).Value = currentTile.Value;
                        currentTile.Value = 0;
                        tmpCol--;
                    }

                    if (tmpCol > 0 && getNext(row, tmpCol).Value == currentTile.Value)
                    {
                        getNext(row, tmpCol).Value *= 2;
                        currentTile.Value = 0;
                    }
                }
            }
        }

        private void MoveRight()
        {
            Func<int, int, Tile> getNext = (row, col) => board[row, col + 1];

            for (int row = 0; row < _boardSize; row++)
            {
                for (int col = _boardSize - 2; col >= 0; col--)
                {
                    int tmpCol = col;
                    var currentTile = board[row, tmpCol];

                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    while (tmpCol < _boardSize - 1 && getNext(row, tmpCol).Value == 0)
                    {
                        getNext(row, tmpCol).Value = currentTile.Value;
                        currentTile.Value = 0;
                        tmpCol++;
                    }

                    if (tmpCol < _boardSize - 1 && getNext(row, tmpCol).Value == currentTile.Value)
                    {
                        getNext(row, tmpCol).Value *= 2;
                        currentTile.Value = 0;
                    }
                }
            }

            //for (int i = 0; i < _boardSize; i++)
            //{
            //    for (int j = _boardSize - 2; j >= 0; j--)
            //    {
            //        if (board[i, j].Value == 0)
            //        {
            //            continue;
            //        }

            //        int k = j;

            //        while (k < _boardSize && board[i, k + 1].Value == 0)
            //        {
            //            board[i, k + 1].Value = board[i, k].Value;
            //            board[i, k].Value = 0;
            //            k++;
            //        }

            //        if (k < _boardSize && board[i, k + 1].Value == board[i, k].Value)
            //        {
            //            board[i, k + 1].Value *= 2;
            //            board[i, k].Value = 0;
            //        }
            //    }
            //}

        }

    }
}
