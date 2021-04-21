using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantMovement.Models
{
    public class CenterButton
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Bitmap ButtonImg { get; private set; }
        public int Size { get; private set; }
        public bool State { get; set; }

        public CenterButton(int x, int y)
        {
            this.X = x;
            this.Y = y;
            Size = 50;
            State = false;
            ButtonImg = new Bitmap(Properties.Resources.Target); // другая картинка будет 
        }
    }
}
