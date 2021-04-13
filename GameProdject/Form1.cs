using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProdject
{


    public partial class Form1 : Form
    {
        private Bitmap TargetBall = new Bitmap(Resource1.Target);
        CenterButton center;
        TargetBall ball;

        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();
		}

        public void Init()
        {
            center = new CenterButton(ClientSize.Width / 2 - 25, ClientSize.Height / 2 - 25);
            ball = new TargetBall(10, 10, 10);
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            var leftBorderEllipse = new Point(ClientSize.Width / 2 - 50, ClientSize.Height / 2 - 50);
            var rightBorderEllipse = new Point(ClientSize.Width / 2 + 50, ClientSize.Height / 2 + 50);

            if (e.Button == MouseButtons.Left && e.X >= leftBorderEllipse.X
                && e.X <= rightBorderEllipse.X && e.Y >= leftBorderEllipse.Y
                && e.Y <= rightBorderEllipse.Y)
            {
                //var rnd = new Random();
                //coordinateX = rnd.Next(0, ClientSize.Width);  
                //coordinateY = rnd.Next(0, ClientSize.Height);
                
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            graphics.DrawImage(center.buttonImg, center.x, center.y, center.size, center.size);
            graphics.DrawImage(ball.targetImg, ball.x, ball.y, ball.size, ball.size);

        }
    }
}
