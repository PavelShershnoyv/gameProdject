using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProdject
{
    class Score
    {
        public int score;
        public Label lable;
        public Point position;

        public Score()
        {
            lable = new Label();
            score = 0;
            lable.Text = string.Format("Score: {0}",score);
            position = new Point(680, 10);
        }
    }
}
