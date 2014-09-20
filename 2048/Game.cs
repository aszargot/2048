﻿using _2048.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2048
{
    public class Game : IEnumerable
    {
        private const int _boardSize = 4;
        private bool _positionChanged;

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

        public Statistics Statistics { get; set; }
        public Action<Game> _binder;
        public Func<int, string> OnGameOver;

        public Game(Action<Game> binder)
        {
            _binder = binder;
            Initialize();
        }

        private void Initialize()
        {
            Board = new Tile[_boardSize, _boardSize];
            Statistics = new Statistics();

            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    board[i, j] = new Tile();
                }
            }

            PlaceNewElementOnTheBoard();
            PlaceNewElementOnTheBoard();
            _binder(this);
        }

        public void StartNewGame()
        {
            Statistics.Score = 0;
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    board[i, j].Value = 0;
                }
            }
            PlaceNewElementOnTheBoard();
            PlaceNewElementOnTheBoard();
        }

        public void Move(Direction direction)
        {
            if (IsGameOver())
            {
                string userName = null;
                if (OnGameOver != null)
                {
                    userName = OnGameOver(Statistics.Score);
                }
                
                this.Statistics.StatsManager.SaveScore(new Score { Username = userName ?? "Player", Value = this.Statistics.Score });

                StartNewGame();
                return;
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
                    var currentTile = board[row, col];
                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    int tmpRow = row;
                    while (tmpRow > 0 && getNext(tmpRow, col).Value == 0)
                    {
                        MoveTile(getNext, col, tmpRow, ref currentTile);
                        tmpRow--;
                    }

                    if (tmpRow > 0 && getNext(tmpRow, col).Value == currentTile.Value)
                    {
                        JoinTiles(getNext, col, tmpRow, currentTile);
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
                    var currentTile = board[row, col];
                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    int tmpRow = row;
                    while (tmpRow < _boardSize - 1 && getNext(tmpRow, col).Value == 0)
                    {
                        MoveTile(getNext, col, tmpRow, ref currentTile);
                        tmpRow++;
                    }

                    if (tmpRow < _boardSize - 1 && getNext(tmpRow, col).Value == currentTile.Value)
                    {
                        JoinTiles(getNext, col, tmpRow, currentTile);
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
                    var currentTile = board[row, col];
                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    int tmpCol = col;
                    while (tmpCol > 0 && getNext(row, tmpCol).Value == 0)
                    {
                        MoveTile(getNext, tmpCol, row, ref currentTile);
                        tmpCol--;
                    }

                    if (tmpCol > 0 && getNext(row, tmpCol).Value == currentTile.Value)
                    {
                        JoinTiles(getNext, tmpCol, row, currentTile);
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
                    var currentTile = board[row, col];
                    if (currentTile.Value == 0)
                    {
                        continue;
                    }

                    int tmpCol = col;
                    while (tmpCol < _boardSize - 1 && getNext(row, tmpCol).Value == 0)
                    {
                        MoveTile(getNext, tmpCol, row, ref currentTile);
                        tmpCol++;
                    }

                    if (tmpCol < _boardSize - 1 && getNext(row, tmpCol).Value == currentTile.Value)
                    {
                        JoinTiles(getNext, tmpCol, row, currentTile);
                    }
                }
            }
        }

        private void JoinTiles(Func<int, int, Tile> getNext, int col, int row, Tile currentTile)
        {
            this.Statistics.Score += currentTile.Value * 2;
            getNext(row, col).Value *= 2;
            currentTile.Value = 0;
            _positionChanged = true;
        }

        private void MoveTile(Func<int, int, Tile> getNext, int col, int row, ref Tile currentTile)
        {
            getNext(row, col).Value = currentTile.Value;
            currentTile.Value = 0;
            currentTile = getNext(row, col);
            _positionChanged = true;
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

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _boardSize; i++)
            {
                for (int j = 0; j < _boardSize; j++)
                {
                    yield return board[i, j];
                }
            }
        }
    }
}
