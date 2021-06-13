using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstantMovement.Models
{
    public class ButtonDesignUI : Control
    {
        private readonly StringFormat StrF = new StringFormat();
        private bool MouseEntered = false;
        private bool MousePressed = false;


        public ButtonDesignUI()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer 
                | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor 
                | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(100, 40);
            BackColor = Color.Tomato;
            ForeColor = Color.White;
            StrF.Alignment = StringAlignment.Center;
            StrF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var graph = e.Graphics;
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            var rectGP = RoundedRectangle(rect, rect.Height - 10);

            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);
            graph.DrawPath(new Pen(BackColor), rectGP);
            graph.FillPath(new SolidBrush(BackColor), rectGP);

            if (MouseEntered)
            {
                graph.DrawPath(new Pen(Color.FromArgb(60, Color.White)), rectGP);
                graph.FillPath(new SolidBrush(Color.FromArgb(60, Color.White)), rectGP);
            }

            if (MousePressed)
            {
                graph.DrawPath(new Pen(Color.FromArgb(30, Color.Black)), rectGP);
                graph.FillPath(new SolidBrush(Color.FromArgb(30, Color.Black)), rectGP);
            }

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, StrF);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            MouseEntered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            MouseEntered = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            MousePressed = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            MousePressed = false;
            Invalidate();
        }

        private GraphicsPath RoundedRectangle(Rectangle rect, int roundSize)
        {
            var graphP = new GraphicsPath();

            graphP.AddArc(rect.X, rect.Y, roundSize, roundSize, 180, 90);
            graphP.AddArc(rect.X + rect.Width - roundSize, rect.Y, roundSize, roundSize, 270, 90);
            graphP.AddArc(rect.X + rect.Width - roundSize, rect.Y + rect.Height - roundSize, roundSize, roundSize, 0, 90);
            graphP.AddArc(rect.X, rect.Y + rect.Height - roundSize, roundSize, roundSize, 90, 90);
            graphP.CloseFigure();

            return graphP;
        }
    }
}
