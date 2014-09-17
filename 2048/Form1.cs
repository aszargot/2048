using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Form1 : Form
    {
        private Game _game;
        private Direction direction;

        public Form1()
        {
            InitializeComponent();
            _game = new Game(BindElements);
            _game.OnGameOver += (s, n) => MessageBox.Show("Przegrales!");
            this.KeyDown += (s, e) => _game.Move(direction);
        }

        private void BindElements(Game game)
        {
            var tiles = flpContainer.Controls.OfType<_2048.Controls.TileElement>();

            if (game.Size != tiles.Count())
            {
                throw new Exception("Invalid number of elements");
            }
            
            tileElement1.DataBindings.Add(new Binding("Text", game.Board[0, 0], "Value"));
            tileElement2.DataBindings.Add(new Binding("Text", game.Board[0, 1], "Value"));
            tileElement3.DataBindings.Add(new Binding("Text", game.Board[0, 2], "Value"));
            tileElement4.DataBindings.Add(new Binding("Text", game.Board[0, 3], "Value"));
            tileElement5.DataBindings.Add(new Binding("Text", game.Board[1, 0], "Value"));
            tileElement6.DataBindings.Add(new Binding("Text", game.Board[1, 1], "Value"));
            tileElement7.DataBindings.Add(new Binding("Text", game.Board[1, 2], "Value"));
            tileElement8.DataBindings.Add(new Binding("Text", game.Board[1, 3], "Value"));
            tileElement9.DataBindings.Add(new Binding("Text", game.Board[2, 0], "Value"));
            tileElement10.DataBindings.Add(new Binding("Text", game.Board[2, 1], "Value"));
            tileElement11.DataBindings.Add(new Binding("Text", game.Board[2, 2], "Value"));
            tileElement12.DataBindings.Add(new Binding("Text", game.Board[2, 3], "Value"));
            tileElement13.DataBindings.Add(new Binding("Text", game.Board[3, 0], "Value"));
            tileElement14.DataBindings.Add(new Binding("Text", game.Board[3, 1], "Value"));
            tileElement15.DataBindings.Add(new Binding("Text", game.Board[3, 2], "Value"));
            tileElement16.DataBindings.Add(new Binding("Text", game.Board[3, 3], "Value"));

            tileElement1.DataBindings.Add(new Binding("BackColor", game.Board[0, 0], "Color"));
            tileElement2.DataBindings.Add(new Binding("BackColor", game.Board[0, 1], "Color"));
            tileElement3.DataBindings.Add(new Binding("BackColor", game.Board[0, 2], "Color"));
            tileElement4.DataBindings.Add(new Binding("BackColor", game.Board[0, 3], "Color"));
            tileElement5.DataBindings.Add(new Binding("BackColor", game.Board[1, 0], "Color"));
            tileElement6.DataBindings.Add(new Binding("BackColor", game.Board[1, 1], "Color"));
            tileElement7.DataBindings.Add(new Binding("BackColor", game.Board[1, 2], "Color"));
            tileElement8.DataBindings.Add(new Binding("BackColor", game.Board[1, 3], "Color"));
            tileElement9.DataBindings.Add(new Binding("BackColor", game.Board[2, 0], "Color"));
            tileElement10.DataBindings.Add(new Binding("BackColor", game.Board[2, 1], "Color"));
            tileElement11.DataBindings.Add(new Binding("BackColor", game.Board[2, 2], "Color"));
            tileElement12.DataBindings.Add(new Binding("BackColor", game.Board[2, 3], "Color"));
            tileElement13.DataBindings.Add(new Binding("BackColor", game.Board[3, 0], "Color"));
            tileElement14.DataBindings.Add(new Binding("BackColor", game.Board[3, 1], "Color"));
            tileElement15.DataBindings.Add(new Binding("BackColor", game.Board[3, 2], "Color"));
            tileElement16.DataBindings.Add(new Binding("BackColor", game.Board[3, 3], "Color"));

            lblScore.DataBindings.Add(new Binding("Text", game.Stats, "Score", true, DataSourceUpdateMode.OnPropertyChanged));
            lblBest.DataBindings.Add(new Binding("Text", game.Stats, "HighScore", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    direction = Direction.Down;
                    break;
                case Keys.Left:
                    direction = Direction.Left;
                    break;
                case Keys.Right:
                    direction = Direction.Right;
                    break;
                case Keys.Up:
                    direction = Direction.Up;
                    break;
                default:
                    return;
            }

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            _game.StartNewGame();
        }
    }
}
