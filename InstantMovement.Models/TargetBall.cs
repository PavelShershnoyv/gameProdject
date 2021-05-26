using System;
using System.Drawing;

namespace InstantMovement.Models
{
    public class TargetBall : GameObject
    {
        public Bitmap TargetImg { get; private set; }

        public TargetBall(int x, int y, int size, bool state)
        {
            X = x;
            Y = y;
            Size = size;
            State = state;
            TargetImg = new Bitmap(Properties.Resources.target1);
        }

        public Bitmap NewColorTargetBall()
        {
            var rnd = new Random();
            switch (rnd.Next(0, 7))
            {
                case 1:
                    return new Bitmap(Properties.Resources.target1);
                case 2:
                    return new Bitmap(Properties.Resources.target2);
                case 3:
                    return new Bitmap(Properties.Resources.target3);
                case 4:
                    return new Bitmap(Properties.Resources.target4);
                case 5:
                    return new Bitmap(Properties.Resources.target5);
                case 6:
                    return new Bitmap(Properties.Resources.target6);
            }
            return new Bitmap(Properties.Resources.target1);
        }
    }
}
