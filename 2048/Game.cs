using _2048.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        public int Size
        {
            get
            {
                return _boardSize * _boardSize;
            }
        }
        private bool _positionChanged;

        private KeyDownListener _keyDownListener;
        public delegate void KeyDownHandler(Direction direction);
        public event KeyDownHandler KeyDownEvent;

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
            //_keyDownListener = new KeyDownListener(this);

            //KeyDownEvent += new KeyDownHandler(_keyDownListener.KeyDownRaises);

            PlaceNewElementOnTheBoard();
            PlaceNewElementOnTheBoard();
        }

        public void Test(Direction direction)
        {
            KeyDownEvent(direction);
        }

        public void Move(Direction direction)
        {
            if (IsGameOver())
            {
                throw new Exception("Game Over!!!");
            }

            _positionChanged = false;
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
                    return;
            }

            if (_positionChanged)
            {
                PlaceNewElementOnTheBoard();
            }
        }

        private void PlaceNewElementOnTheBoard()
        {
            var emptyTiles = new List<Tile>();
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    if (board[i, j].Value == 0)
                    {
                        emptyTiles.Add(board[i, j]);
                    }
                }
            }

            if (emptyTiles.Count > 0)
            {
                var randomEmptyTile = emptyTiles.OrderBy(n => Guid.NewGuid()).First();
                randomEmptyTile.Value = 2;
            }
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
                        currentTile = getNext(tmpRow, col);
                        tmpRow--;
                        _positionChanged = true;
                    }

                    if (tmpRow > 0 && getNext(tmpRow, col).Value == currentTile.Value)
                    {
                        getNext(tmpRow, col).Value *= 2;
                        currentTile.Value = 0;
                        _positionChanged = true;
                        this.Foreground = Color.Blue;
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
                        currentTile = getNext(tmpRow, col);
                        tmpRow++;
                        _positionChanged = true;
                    }

                    if (tmpRow < _boardSize - 1 && getNext(tmpRow, col).Value == currentTile.Value)
                    {
                        getNext(tmpRow, col).Value *= 2;
                        currentTile.Value = 0;
                        _positionChanged = true;
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
                        currentTile = getNext(row, tmpCol);
                        tmpCol--;
                        _positionChanged = true;
                    }

                    if (tmpCol > 0 && getNext(row, tmpCol).Value == currentTile.Value)
                    {
                        getNext(row, tmpCol).Value *= 2;
                        currentTile.Value = 0;
                        _positionChanged = true;
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
                        currentTile = getNext(row, tmpCol);
                        tmpCol++;
                        _positionChanged = true;
                    }

                    if (tmpCol < _boardSize - 1 && getNext(row, tmpCol).Value == currentTile.Value)
                    {
                        getNext(row, tmpCol).Value *= 2;
                        currentTile.Value = 0;
                        _positionChanged = true;
                    }
                }
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
            bool up = row == 0 ? false : board[row - 1, col].Value == currentTile.Value;

            return left || right || down || up;
        }

        public Color BackColor { get; set; }

        public Color Foreground { get; set; }
    }
}
