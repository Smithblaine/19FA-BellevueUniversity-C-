using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void Label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void Label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void Label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
        }

        private void Label5_MouseHover(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
        }

    }
}
