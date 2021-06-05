using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantMovement.Models
{
    public class CenterButton : GameObject
    {
        public Bitmap ButtonImg { get; private set; }
        public Bitmap StartButtonImg { get; private set; }

        public CenterButton(int x, int y, bool state)
        {
            X = x;
            Y = y;
            Size = 50;
            State = state;
            StartButtonImg = new Bitmap(Properties.Resources.Start);
            ButtonImg = new Bitmap(Properties.Resources.Center_button);
        }
        // логика проверки должна быть тут 
        public Bitmap SwitchButton(Score score, CenterButton center)
        {
            if (score.Counter < 1 && center.State != false)
                return new Bitmap(Properties.Resources.Start);
            else
                return new Bitmap(Properties.Resources.Center_button);
        }
    }
}
