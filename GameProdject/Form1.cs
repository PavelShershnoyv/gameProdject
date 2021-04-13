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
    public class GameModel
    {
        private int Width;
        private int Height;
        private Bitmap TargetBall = new Bitmap(Resource1.Target);
        private int coordinateX = 0;
        private int coordinateY = 0;

        public GameModel(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }

    public class Cards
    {
        Point location = Point.Empty;
    }

    public partial class Form1 : Form
    {
        private GameModel game;


        public Form1(GameModel game)
        {
            this.game = game;
            //TargetBall = new PictureBox();
            //TargetBall.Image = new Bitmap(Resource1.Target);// как иначе?  Я пробовал 
            //TargetBall.BackColor = Color.Black;
            InitializeComponent();
            //GenerateTargetBalls();
		}

        public void GenerateTargetBalls()
        {
            var rnd = new Random();
            var coordinateX = rnd.Next(0, ClientSize.Width); // Отвечай 
            var coordinateY = rnd.Next(0, ClientSize.Height);

            //TargetBall.Location = new Point(coordinateX, coordinateY);
            //this.Controls.Add(TargetBall);
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
            var rectEllipse = new Rectangle(ClientSize.Width / 2 - 50, ClientSize.Height / 2 - 50, 100, 100);

            graphics.DrawEllipse(new Pen(Color.Black, 5), rectEllipse);
            graphics.FillEllipse(Brushes.Red, rectEllipse);

            //graphics.DrawImage(TargetBall, new Rectangle(coordinateX, coordinateY, 100, 100));

        }
    }
}
