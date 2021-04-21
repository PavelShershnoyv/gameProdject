using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantMovement.Models
{
    public class TargetBall
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public bool State { get; set; }
        public Bitmap TargetImg { get; private set; }

        public TargetBall(int x, int y, int size)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
            State = true;
            TargetImg = new Bitmap(Properties.Resources.Target); // другая картинка будет 
        }

    }
}
