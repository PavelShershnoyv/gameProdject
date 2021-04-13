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
        private CenterButton center;
        private TargetBall ball;
        private Score score;

        public Form1()
        {
            InitializeComponent();
            Init();
            Invalidate();
		}

        public void Init()
        {
            center = new CenterButton(ClientSize.Width / 2 - 25, ClientSize.Height / 2 - 25);
            ball = new TargetBall(10, 10, 20);
            score = new Score();
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            var leftBorderCenter = new Point(center.x, center.y);
            var rightBorderCenter = new Point(center.x + center.size, center.y + center.size);
            var leftBorderBall = new Point(ball.x, ball.y);
            var rightBorderBall = new Point(ball.x + ball.size, ball.y + ball.size);

            if (e.Button == MouseButtons.Left && e.X >= leftBorderCenter.X
                && e.X <= rightBorderCenter.X && e.Y >= leftBorderCenter.Y
                && e.Y <= rightBorderCenter.Y && ball.state)
            {
                ball.state = false;
                center.state = true;
                var rnd = new Random();
                ball.size = rnd.Next(15, 40);
                ball.x = rnd.Next(0, ClientSize.Width - ball.size);  
                ball.y = rnd.Next(0, ClientSize.Height - ball.size);
                Invalidate();
            }

            if (e.Button == MouseButtons.Left && e.X >= leftBorderBall.X
                && e.X <= rightBorderBall.X && e.Y >= leftBorderBall.Y
                && e.Y <= rightBorderBall.Y)
            {
                ball.state = true;
                center.state = false;
                score.score +=1;
                Invalidate();
            }

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            graphics.DrawString(score.lable.Text, new Font("Arial", 16), 
                new SolidBrush(Color.Black), score.position.X, score.position.Y);
            graphics.DrawImage(center.buttonImg, center.x, center.y, center.size, center.size);
            if (center.state)
                graphics.DrawImage(ball.targetImg, ball.x, ball.y, ball.size, ball.size);

        }
    }
}
