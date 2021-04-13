using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProdject
{
    class TargetBall
    {
        public int x;
        public int y;
        public int size;
        public Bitmap targetImg;

        public TargetBall(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
            targetImg = new Bitmap(Resource1.Target); // другая картинка будет 
        }

    }
}
