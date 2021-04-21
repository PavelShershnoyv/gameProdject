using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace InstantMovement.Models
{
    public class Score
    {
        public int Counter { get; set; }
        public Label Lable { get; set; }
        public Point Position { get; set; }

        public Score()
        {
            Lable = new Label();
            Counter = 0;
            
            //lable.Text = string.Format("Score: {0}", score);
            Position = new Point(680, 10);
        }
    }
}
