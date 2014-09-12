using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public static System.Drawing.Color Foreground { get; set; }
    }
}
