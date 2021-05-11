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
        private readonly PictureBox[] pictureBoxes;

        public Form3()
        {
            InitializeComponent();
            pairs = new int[12];
            allCards = new int[24];
            counterOpenedCards = 0;
            opened = new int[2];
            pictureBoxes = new PictureBox[24];
            pictureBoxes[0] = pictureBox1;
            pictureBoxes[1] = pictureBox2;
            pictureBoxes[2] = pictureBox3;
            pictureBoxes[3] = pictureBox4;
            pictureBoxes[4] = pictureBox5;
            pictureBoxes[5] = pictureBox6;
            pictureBoxes[6] = pictureBox7;
            pictureBoxes[7] = pictureBox8;
            pictureBoxes[8] = pictureBox9;
            pictureBoxes[9] = pictureBox10;
            pictureBoxes[10] = pictureBox11;
            pictureBoxes[11] = pictureBox12;
            pictureBoxes[12] = pictureBox13;
            pictureBoxes[13] = pictureBox14;
            pictureBoxes[14] = pictureBox15;
            pictureBoxes[15] = pictureBox16;
            pictureBoxes[16] = pictureBox17;
            pictureBoxes[17] = pictureBox18;
            pictureBoxes[18] = pictureBox19;
            pictureBoxes[19] = pictureBox20;
            pictureBoxes[20] = pictureBox21;
            pictureBoxes[21] = pictureBox22;
            pictureBoxes[22] = pictureBox23;
            pictureBoxes[23] = pictureBox24;
        }

        private void HideCards()
        {
            pictureBox1.BackgroundImage = imageList1.Images[4];// изначально стоит обложка
            pictureBox2.BackgroundImage = imageList1.Images[4];
            pictureBox3.BackgroundImage = imageList1.Images[4];
            pictureBox4.BackgroundImage = imageList1.Images[4];
            pictureBox5.BackgroundImage = imageList1.Images[4];
            pictureBox6.BackgroundImage = imageList1.Images[4];
            pictureBox7.BackgroundImage = imageList1.Images[4];
            pictureBox8.BackgroundImage = imageList1.Images[4];
            pictureBox9.BackgroundImage = imageList1.Images[4];
            pictureBox10.BackgroundImage = imageList1.Images[4];
            pictureBox11.BackgroundImage = imageList1.Images[4];
            pictureBox12.BackgroundImage = imageList1.Images[4];
            pictureBox13.BackgroundImage = imageList1.Images[4];
            pictureBox14.BackgroundImage = imageList1.Images[4];
            pictureBox15.BackgroundImage = imageList1.Images[4];
            pictureBox16.BackgroundImage = imageList1.Images[4];
            pictureBox17.BackgroundImage = imageList1.Images[4];
            pictureBox18.BackgroundImage = imageList1.Images[4];
            pictureBox19.BackgroundImage = imageList1.Images[4];
            pictureBox20.BackgroundImage = imageList1.Images[4];
            pictureBox21.BackgroundImage = imageList1.Images[4];
            pictureBox22.BackgroundImage = imageList1.Images[4];
            pictureBox23.BackgroundImage = imageList1.Images[4];
            pictureBox24.BackgroundImage = imageList1.Images[4];
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HideCards();

            // first row ------------------------------------------------------------------
            pictureBox1.Top = 0;
            pictureBox1.Left = 0;
            pictureBox1.Width = panel1.Width / 4;
            pictureBox1.Height = panel1.Height / 6;

            pictureBox2.Top = 0;
            pictureBox2.Left = panel1.Width / 4;
            pictureBox2.Width = panel1.Width / 4;
            pictureBox2.Height = panel1.Height / 6;

            pictureBox3.Top = 0;
            pictureBox3.Left = panel1.Width * 2/ 4;
            pictureBox3.Width = panel1.Width / 4;
            pictureBox3.Height = panel1.Height / 6;

            pictureBox4.Top = 0;
            pictureBox4.Left = panel1.Width * 3 / 4;
            pictureBox4.Width = panel1.Width / 4;
            pictureBox4.Height = panel1.Height / 6;

            // second row ------------------------------------------------------------------
            pictureBox5.Top = panel1.Height / 6;
            pictureBox5.Left = 0;
            pictureBox5.Width = panel1.Width / 4;
            pictureBox5.Height = panel1.Height / 6;

            pictureBox6.Top = panel1.Height / 6;
            pictureBox6.Left = panel1.Width / 4;
            pictureBox6.Width = panel1.Width / 4;
            pictureBox6.Height = panel1.Height / 6;

            pictureBox7.Top = panel1.Height / 6; 
            pictureBox7.Left = panel1.Width * 2 / 4;
            pictureBox7.Width = panel1.Width / 4;
            pictureBox7.Height = panel1.Height / 6;

            pictureBox8.Top = panel1.Height / 6;
            pictureBox8.Left = panel1.Width * 3 / 4;
            pictureBox8.Width = panel1.Width / 4;
            pictureBox8.Height = panel1.Height / 6;

            // third row ------------------------------------------------------------------
            pictureBox9.Top = panel1.Height * 2/ 6;
            pictureBox9.Left = 0;
            pictureBox9.Width = panel1.Width / 4;
            pictureBox9.Height = panel1.Height / 6;

            pictureBox10.Top = panel1.Height * 2 / 6;
            pictureBox10.Left = panel1.Width / 4;
            pictureBox10.Width = panel1.Width / 4;
            pictureBox10.Height = panel1.Height / 6;

            pictureBox11.Top = panel1.Height * 2 / 6;
            pictureBox11.Left = panel1.Width * 2 / 4;
            pictureBox11.Width = panel1.Width / 4;
            pictureBox11.Height = panel1.Height / 6;

            pictureBox12.Top = panel1.Height * 2 / 6;
            pictureBox12.Left = panel1.Width * 3 / 4;
            pictureBox12.Width = panel1.Width / 4;
            pictureBox12.Height = panel1.Height / 6;

            // fourth row ------------------------------------------------------------------
            pictureBox13.Top = panel1.Height * 3 / 6;
            pictureBox13.Left = 0;
            pictureBox13.Width = panel1.Width / 4;
            pictureBox13.Height = panel1.Height / 6;

            pictureBox14.Top = panel1.Height * 3 / 6;
            pictureBox14.Left = panel1.Width / 4;
            pictureBox14.Width = panel1.Width / 4;
            pictureBox14.Height = panel1.Height / 6;

            pictureBox15.Top = panel1.Height * 3 / 6;
            pictureBox15.Left = panel1.Width * 2 / 4;
            pictureBox15.Width = panel1.Width / 4;
            pictureBox15.Height = panel1.Height / 6;

            pictureBox16.Top = panel1.Height * 3 / 6;
            pictureBox16.Left = panel1.Width * 3 / 4;
            pictureBox16.Width = panel1.Width / 4;
            pictureBox16.Height = panel1.Height / 6;

            // fifth row ------------------------------------------------------------------
            pictureBox17.Top = panel1.Height * 4 / 6;
            pictureBox17.Left = 0;
            pictureBox17.Width = panel1.Width / 4;
            pictureBox17.Height = panel1.Height / 6;

            pictureBox18.Top = panel1.Height * 4 / 6;
            pictureBox18.Left = panel1.Width / 4;
            pictureBox18.Width = panel1.Width / 4;
            pictureBox18.Height = panel1.Height / 6;

            pictureBox19.Top = panel1.Height * 4 / 6;
            pictureBox19.Left = panel1.Width * 2 / 4;
            pictureBox19.Width = panel1.Width / 4;
            pictureBox19.Height = panel1.Height / 6;

            pictureBox20.Top = panel1.Height * 4 / 6;
            pictureBox20.Left = panel1.Width * 3 / 4;
            pictureBox20.Width = panel1.Width / 4;
            pictureBox20.Height = panel1.Height / 6;

            // sixth row ------------------------------------------------------------------
            pictureBox21.Top = panel1.Height * 5 / 6;
            pictureBox21.Left = 0;
            pictureBox21.Width = panel1.Width / 4;
            pictureBox21.Height = panel1.Height / 6;

            pictureBox22.Top = panel1.Height * 5 / 6;
            pictureBox22.Left = panel1.Width / 4;
            pictureBox22.Width = panel1.Width / 4;
            pictureBox22.Height = panel1.Height / 6;

            pictureBox23.Top = panel1.Height * 5 / 6;
            pictureBox23.Left = panel1.Width * 2 / 4;
            pictureBox23.Width = panel1.Width / 4;
            pictureBox23.Height = panel1.Height / 6;

            pictureBox24.Top = panel1.Height * 5 / 6;
            pictureBox24.Left = panel1.Width * 3 / 4;
            pictureBox24.Width = panel1.Width / 4;
            pictureBox24.Height = panel1.Height / 6;

            NewToolStripMenuItem_Click(null, null);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var usedPairs = 0;

            counterOpenedCards = 0;
            for (var i = 0; i < 24; i++)
            {
                pictureBoxes[i].Visible = true;
                allCards[i] = -1;
            }
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
                pictureBoxes[opened[0]].Visible = false;
                pictureBoxes[opened[1]].Visible = false;
            }
            pictureBox.BackgroundImage = imageList1.Images[allCards[index]];
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
