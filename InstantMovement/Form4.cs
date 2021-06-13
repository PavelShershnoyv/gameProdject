using System;
using InstantMovement.Models;
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
    public partial class Form4 : Form
    {
        private readonly int mapSize = 24;
        private static Cells cell;
        private PictureBox fruit;
        private (int, int)[,] map;
        private PictureBox[] snake;
        private int r1, r2;
        private static new int Height;
        private static new int Width;
        private List<Point> shortWay;
        private bool flag = true;

        public Form4()
        {
            InitializeComponent();
            this.Text = "Сломай фрукт";
            Init();
        }

        private void Init()
        {
            shortWay = default;
            cell = new Cells();
            snake = new PictureBox[7];
            map = new (int, int)[mapSize, mapSize];
            for (var i = 0; i < map.GetLength(0); i++)
                for (var j = 0; j < map.GetLength(1); j++)
                    map[i, j] = (i, j);
            Width = mapSize * cell.Size;
            Height = mapSize * cell.Size + cell.Size;
            CreateMap();
            CreateFruit();
            CreateSnake();
            timer.Tick += new EventHandler(Update);
            timer.Interval = 200;
            timer.Start();
        }

        private void Update(object obj, EventArgs e)
        {
            if (flag)
            {
                shortWay = FindPaths(snake[0].Location, fruit.Location).Reverse().Skip(1).ToList();
                flag = false;
            }
            EatFruit();
            MoveSnake();
        }


        private void CreateFruit()
        {
            fruit = new PictureBox
            {
                BackColor = Color.Yellow,
                Size = new Size(cell.Size - 1, cell.Size - 1),
                Tag = 1
            };
            var rnd1 = new Random();
            r1 = rnd1.Next(0, (Height - cell.Size)/2);
            var temp = r1 % cell.Size;
            r1 -= temp;
            var rnd2 = new Random();
            r2 = rnd2.Next(0, Height - cell.Size);
            var temp2 = r2 % cell.Size;
            r2 -= temp2;
            fruit.Location = new Point(r1, r2);
            this.Controls.Add(fruit);
            fruit.Click += new System.EventHandler(this.FruitClick);
        }

        private void FruitClick(object sender, EventArgs e)
        {
            fruit.Visible = false;
            CreateFruit();
            shortWay = FindPaths(snake[0].Location, fruit.Location).Reverse().Skip(1).ToList();
        }

        private void CreateSnake()
        {
            var coordX = 210;
            var coordY = 210;

            for (var i = 0; i < snake.Length; i++)
            {
                snake[i] = new PictureBox
                {
                    Location = new Point(coordX, coordY),
                    BackColor = Color.Red,
                    Size = new Size(cell.Size, cell.Size)
                };
                this.Controls.Add(snake[i]);
                coordY += cell.Size;
            }
        }

        private void MoveSnake()
        {
            if (snake[0].Location != fruit.Location)
            {
                for (var i = snake.Length - 1; i >= 1; i--)
                    snake[i].Location = snake[i - 1].Location;
                snake[0].Location = shortWay.FirstOrDefault();
                shortWay.Remove(shortWay.FirstOrDefault());
            }
        }

        private void EatFruit()
        {
            if (snake[0].Location == fruit.Location)
            {
                timer.Stop();
                MessageBox.Show("Game over");
            }
        }


        private void CreateMap()
        {
            for (var i = 0; i < Width / cell.Size; i++)
            {
                var line = new PictureBox
                {
                    BackColor = Color.Black,
                    Location = new Point(0, cell.Size * i),
                    Size = new Size(Width, 1)
                };
                this.Controls.Add(line);
            }

            for (var i = 0; i < Height / cell.Size; i++)
            {
                var line = new PictureBox
                {
                    BackColor = Color.Black,
                    Location = new Point(cell.Size * i, 0),
                    Size = new Size(1, Height)
                };
                this.Controls.Add(line);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form1();
            form.ShowDialog();
            Close();
        }

        public static SinglyLinkedList<Point> FindPaths(Point start, Point fruit)
        {
            var visited = new HashSet<Point>();
            var queue = new Queue<SinglyLinkedList<Point>>();
            queue.Enqueue(new SinglyLinkedList<Point>(start, null));
            visited.Add(start);
            while (queue.Count != 0)
            {
                var point = queue.Dequeue();
                if (point.Value.X <= 0 && point.Value.Y <= 0 && point.Value.Y >= Height && point.Value.X >= Width) continue;
                for (var dy = -1; dy <= 1; dy++)
                    for (var dx = -1; dx <= 1; dx++)
                    {
                        if (dx != 0 && dy != 0) continue;
                        var nextPoint = new Point(point.Value.X + dx * cell.Size, point.Value.Y + dy * cell.Size);

                        if (visited.Contains(nextPoint)) continue;
                        visited.Add(nextPoint);
                        var newElementInQueue = new SinglyLinkedList<Point>(nextPoint,point);
                        queue.Enqueue(newElementInQueue);
                        if (fruit == nextPoint)
                            return newElementInQueue;
                    }
            }
            return default;
        }
    }
}

