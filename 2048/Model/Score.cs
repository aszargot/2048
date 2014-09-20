using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048.Model
{
    public class Score
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Username { get; set; }
        public int Value { get; set; }
    }
}
