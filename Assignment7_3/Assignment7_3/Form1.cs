//Blaine Smith
//12-7-2019
//Bellevue University
//Assignment 7.3
//This program allows a user to select a button that will change the background color of the form.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            blue.Click += new EventHandler(Button_Blue);
            green.Click += new EventHandler(Button_Green);
            red.Click += new EventHandler(Button_Red);
            yellow.Click += new EventHandler(Button_Yellow);
            orange.Click += new EventHandler(Button_Orange);
        }

        private void Button_Blue(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Blue;
        }

        private void Button_Green(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Green;
        }

        private void Button_Red(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Red;
        }

        private void Button_Yellow(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Yellow;
        }

        private void Button_Orange(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Orange;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
