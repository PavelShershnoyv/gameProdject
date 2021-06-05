using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InstantMovement.Models
{
    public class Cells : GameObject
    {
        public Color Color { get; set; }

        public Cells()
        {
            Size = 30;
        }
    }
}
