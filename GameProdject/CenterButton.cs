using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProdject
{
    class CenterButton
    {
        public int x;
        public int y;
        public Bitmap buttonImg;
        public int size;

        public CenterButton(int x, int y)
        {
            this.x = x;
            this.y = y;
            size = 50;
            buttonImg = new Bitmap(Resource1.Target); // другая картинка будет 
        }
    }
}
