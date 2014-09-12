using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    public class KeyDownListener
    {
        private Game _game;

        public KeyDownListener(Game game)
        {
            _game = game;
        }

        public void KeyDownRaises(Direction direction)
        {
            _game.Move(direction);
        }
    }
}
