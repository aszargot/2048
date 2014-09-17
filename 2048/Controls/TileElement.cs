using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048.Controls
{
    public class TileElement : Button
    {
        public TileElement() : base()
        {
            this.Text = "0";
            this.Width = 120;
            this.Height = 120;
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Open Sans", 8, 
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Millimeter, 0);
        }
    }
}
