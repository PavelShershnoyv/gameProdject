using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantMovement.Models
{
    public class Cards
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool State { get; set; }
        public Bitmap ButtonImg { get; set; }
        public Cards()
        {
            State = false;
            ButtonImg = new Bitmap(Properties.Resources.Target); // другая картинка будет 
        }
    }
}
