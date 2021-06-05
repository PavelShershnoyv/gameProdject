using System.Drawing;
using System;

namespace InstantMovement.Models
{
    public class Cards : GameObject
    {
        public Bitmap CardImg { get; set; }
        public int Count { get; set; }
        public Cards(int x, int y, bool state)
        {
            X = x;
            Y = y;
            State = state;
            Size = 110;
            //ButtonImg = new Bitmap(Properties.Resources.Target); // другая картинка будет 
        }

        public void HideCards()
        {
            for (var i = 0; i < this.Count; i++)
                CardImg = new Bitmap(Properties.Resources.backSide);
        }
    }
}
