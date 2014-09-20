using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.Model
{
    public class Tile : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _value;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                OnPropertyChanged("Value");
            }
        }

        public Color Color
        {
            get
            {
                return _value <= 2048 && _value > 0 ? colors[_value] : Color.White;
            }
        }

        private Dictionary<int, Color> colors;

        public Tile()
        {
            colors = new Dictionary<int, Color>
            {
                {2, Color.PowderBlue },
                {4, Color.LightBlue},
                {8, Color.Aqua},
                {16, Color.MediumTurquoise},
                {32, Color.Turquoise},
                {64, Color.PaleGreen },
                {128, Color.MediumSpringGreen},
                {256, Color.Lime},
                {512, Color.LimeGreen},
                {1024, Color.Green},
                {2048, Color.Indigo},
            };
        }

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
