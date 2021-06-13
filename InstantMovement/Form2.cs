using InstantMovement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstantMovement
{


    public partial class Form2 : Form
    {
        private CenterButton center;
        private TargetBall ball;
        private Score score;
        private DateTime date;
        private int targetCount;
        private Timer timer;
        private bool stoppingPoint;

        public Form2()
        {
            InitializeComponent();
            this.Text = "Кликни на цель";
            Init();
            Invalidate();
        }

        public void Init()
        {
            center = new CenterButton(ClientSize.Width / 2 - 25, ClientSize.Height / 2 - 25, true);
            ball = new TargetBall(10, 10, 20, false);
            score = new Score();
            timer = new Timer();
            targetCount = -1;
            stoppingPoint = true;
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            var leftBorderCenter = new Point(center.X, center.Y);
            var rightBorderCenter = new Point(center.X + center.Size, center.Y + center.Size);
            var leftBorderBall = new Point(ball.X, ball.Y);
            var rightBorderBall = new Point(ball.X + ball.Size, ball.Y + ball.Size);

            if (e.Button == MouseButtons.Left && e.X >= leftBorderCenter.X
                && e.X <= rightBorderCenter.X && e.Y >= leftBorderCenter.Y
                && e.Y <= rightBorderCenter.Y && !ball.State)
            {

                if (score.Counter == 0)
                {
                    date = DateTime.Now;
                    timer.Interval = 10;
                    timer.Tick += new EventHandler(TickTimer);
                    timer.Start();
                }

                if (score.Counter == targetCount)
                {
                    timer.Stop();
                    stoppingPoint = false;
                    toolStripLabel1.ForeColor = Color.Red;
                }

                ball.State = true;
                center.State = false;
                var flag = false;
                var rnd = new Random();
                ball.Size = rnd.Next(15, 40);
                while (flag == false)
                {
                    var x = rnd.Next(0, ClientSize.Width - ball.Size);
                    var y = rnd.Next(0, ClientSize.Height - 80 - ball.Size);
                    if (x >= leftBorderCenter.X
                    && x <= rightBorderCenter.X && y >= leftBorderCenter.Y
                    && y <= rightBorderCenter.Y)
                        continue;
                    else
                    {
                        ball.X = x;
                        ball.Y = y;
                        flag = true;
                    }
                }
                Invalidate();
            }

            if (e.Button == MouseButtons.Left && e.X >= leftBorderBall.X
                && e.X <= rightBorderBall.X && e.Y >= leftBorderBall.Y
                && e.Y <= rightBorderBall.Y)
            {
                ball.State = false;
                center.State = true;
                score.Counter++;
                Invalidate();
            }

        }

        private void TickTimer(object sender, EventArgs e)
        {
            var tick = DateTime.Now.Ticks - date.Ticks;
            var stopWatch = new DateTime();

            stopWatch = stopWatch.AddTicks(tick);
            toolStripLabel1.Text = String.Format("{0:HH:mm:ss:ff}", stopWatch);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (score.Counter < 1 && center.State != false)
                graphics.DrawImage(center.StartButtonImg, center.X, center.Y, center.Size, center.Size);
            else
                graphics.DrawImage(center.ButtonImg, center.X, center.Y, center.Size, center.Size); 

            if (ball.State && stoppingPoint)
                graphics.DrawImage(ball.NewColorTargetBall(), ball.X, ball.Y, ball.Size, ball.Size);

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            targetCount = GetCountTarget(sender.ToString());
            SetColor(targetCount);
        }

        private int GetCountTarget(string name)
        {
            switch (Convert.ToInt32(name))
            {
                case 5:
                    return 5;
                case 15:
                    return 15;
                case 30:
                    return 30;
                case 50:
                    return 50;
                case 80:
                    return 80;
                case 100:
                    return 100;
            }
            return 0;
        }

        private void SetColor(int number)
        {
            toolStripButton2.BackColor = Color.FromArgb(1);
            toolStripButton3.BackColor = Color.FromArgb(1);
            toolStripButton4.BackColor = Color.FromArgb(1);
            toolStripButton5.BackColor = Color.FromArgb(1);
            toolStripButton6.BackColor = Color.FromArgb(1);
            toolStripButton7.BackColor = Color.FromArgb(1);
            switch (number)
            {
                case 5:
                    toolStripButton2.BackColor = Color.Gray;
                    break;
                case 15:
                    toolStripButton3.BackColor = Color.Gray;
                    break;
                case 30:
                    toolStripButton4.BackColor = Color.Gray;
                    break;
                case 50:
                    toolStripButton5.BackColor = Color.Gray;
                    break;
                case 80:
                    toolStripButton6.BackColor = Color.Gray;
                    break;
                case 100:
                    toolStripButton7.BackColor = Color.Gray;
                    break;
            }
        }
    }
}
