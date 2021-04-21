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
        private Cards cards;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString()); Image.FromFile(@"C: \Users\ПАВЕЛ\Desktop\отпечаток")
            sender.GetType().GetProperty("image").SetValue(sender, cards.ButtonImg);
        }
    }
}
