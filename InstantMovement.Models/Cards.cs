using System.Drawing;

namespace InstantMovement.Models
{
    public class Cards : GameObject
    {
        public Bitmap ButtonImg { get; set; }
        public Cards(int x, int y, bool state)
        {
            X = x;
            Y = y;
            State = state;
            Size = 110;
            //ButtonImg = new Bitmap(Properties.Resources.Target); // другая картинка будет 
        }
    }
}
