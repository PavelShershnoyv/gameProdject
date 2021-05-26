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
    public partial class Form3 : Form
    {
        //private Cards cards;
        private readonly int[] pairs;
        private readonly int[] allCards;
        private readonly int[] opened;
        private int counterOpenedCards;
        private readonly PictureBox[,] pictureBoxes;
        private readonly int row; // строка
        private readonly int column; // столбец

        public Form3()
        {
            InitializeComponent();
            pairs = new int[12];
            allCards = new int[24];
            counterOpenedCards = 0;
            opened = new int[2];
            row = 6;
            column = 4;
            pictureBoxes = new PictureBox[row,column];
            pictureBoxes[0,0] = pictureBox1;
            pictureBoxes[0,1] = pictureBox2;
            pictureBoxes[0,2] = pictureBox3;
            pictureBoxes[0,3] = pictureBox4;
            pictureBoxes[1,0] = pictureBox5;
            pictureBoxes[1,1] = pictureBox6;
            pictureBoxes[1,2] = pictureBox7;
            pictureBoxes[1,3] = pictureBox8;
            pictureBoxes[2,0] = pictureBox9;
            pictureBoxes[2,1] = pictureBox10;
            pictureBoxes[2,2] = pictureBox11;
            pictureBoxes[2,3] = pictureBox12;
            pictureBoxes[3,0] = pictureBox13;
            pictureBoxes[3,1] = pictureBox14;
            pictureBoxes[3,2] = pictureBox15;
            pictureBoxes[3,3] = pictureBox16;
            pictureBoxes[4,0] = pictureBox17;
            pictureBoxes[4,1] = pictureBox18;
            pictureBoxes[4,2] = pictureBox19;
            pictureBoxes[4,3] = pictureBox20;
            pictureBoxes[5,0] = pictureBox21;
            pictureBoxes[5,1] = pictureBox22;
            pictureBoxes[5,2] = pictureBox23;
            pictureBoxes[5,3] = pictureBox24;
        }

        private void HideCards()
        {
            for (var i = 0; i < pictureBoxes.GetLength(0); i++)
                for (var j = 0; j  < pictureBoxes.GetLength(1); j ++)
                    pictureBoxes[i,j].BackgroundImage = imageList1.Images[4];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HideCards();

            for (var i = 0; i < pictureBoxes.GetLength(0); i++)
                for (var j = 0; j < pictureBoxes.GetLength(1); j++)
                {
                    pictureBoxes[i,j].Top = panel1.Height * i / row;
                    pictureBoxes[i, j].Left = panel1.Width * j / column;
                    pictureBoxes[i,j].Width = panel1.Width / column;
                    pictureBoxes[i,j].Height = panel1.Height / row;
                }

            NewToolStripMenuItem_Click(null, null);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var usedPairs = 0;

            counterOpenedCards = 0;
            for (var i = 0; i < pictureBoxes.GetLength(0); i++)
                for (var j = 0; j < pictureBoxes.GetLength(1); j++)
                    pictureBoxes[i,j].Visible = true;

            for (int i = 0; i < pictureBoxes.Length; i++)
                allCards[i] = -1;

            for (var i = 0; i < 12; i++)
                pairs[i] = rnd.Next(4);// кол-во картинок в листе 
            while (usedPairs != 12)
            {
                var firstNumber = rnd.Next(24);
                var secondNumber = rnd.Next(24);

                if (firstNumber == secondNumber) continue;
                if (allCards[firstNumber] == -1 && allCards[secondNumber] == -1)
                {
                    allCards[firstNumber] = allCards[secondNumber] = pairs[usedPairs];
                    usedPairs++;
                }
            }
            HideCards();
        }

        private void PictureBox24_Click(object sender, EventArgs e)
        {
            var pictureBox = (PictureBox)sender;
            var index = Convert.ToInt32(pictureBox.Tag);
            if (counterOpenedCards == 1 && opened[0] == index)
                return;
            if (counterOpenedCards == 2)
            {
                HideCards();
                counterOpenedCards = 0;
            }
            opened[counterOpenedCards] = index;
            counterOpenedCards++;
            if (counterOpenedCards == 2 && allCards[opened[0]] == allCards[opened[1]])
            {
                var valuesOpened = TransformNumber(opened[0]);
                pictureBoxes[valuesOpened.Item1, valuesOpened.Item2].Visible = false;
                valuesOpened = TransformNumber(opened[1]);
                pictureBoxes[valuesOpened.Item1, valuesOpened.Item2].Visible = false;
            }
            pictureBox.BackgroundImage = imageList1.Images[allCards[index]];
        }

        private static (int,int) TransformNumber(int numberPictureBox)
        {
            switch (numberPictureBox)
            {
                case 0:
                    return (0, 0);
                case 1:
                    return (0, 1);
                case 2:
                    return (0, 2);
                case 3:
                    return (0, 3);
                case 4:
                    return (1, 0);
                case 5:
                    return (1, 1);
                case 6:
                    return (1, 2);
                case 7:
                    return (1, 3);
                case 8:
                    return (2, 0);
                case 9:
                    return (2, 1);
                case 10:
                    return (2, 2);
                case 11:
                    return (2, 3);
                case 12:
                    return (3, 0);
                case 13:
                    return (3, 1);
                case 14:
                    return (3, 2);
                case 15:
                    return (3, 3);
                case 16:
                    return (4, 0);
                case 17:
                    return (4, 1);
                case 18:
                    return (4, 2);
                case 19:
                    return (4, 3);
                case 20:
                    return (5, 0);
                case 21:
                    return (5, 1);
                case 22:
                    return (5, 2);
                case 23:
                    return (5, 3);
            }
            return (-1, -1);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new Form1();
            form.ShowDialog();
            Close();
        }
    }
}
