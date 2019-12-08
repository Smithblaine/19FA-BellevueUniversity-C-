
//Blaine Smith
//12-07-2019
//Bellevue University
//Assignment 7.2
//This program allows a user to choose which internet access they would like to have in their home.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            yes1.Click += new EventHandler(Start_Yes);
            no1.Click += new EventHandler(Start_No);
        }

        public void Start_Yes(object sender, EventArgs e)
        {
            string message = "Do you want Limited access for $10.95 a month?\nor Unlimited for $19.95 a month\nClick Yes for Limited and No for Unlimited";
            string selectYes = "You have selected limited access for $10.95 a month";
            string selectNo = "You have selected Unlimited access for $19.95 a month";

            DialogResult result = MessageBox.Show(message, "" ,MessageBoxButtons.YesNoCancel);
            
            if (result == DialogResult.Yes)
            {
                MessageBox.Show(selectYes, "", MessageBoxButtons.OK);
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show(selectNo, "", MessageBoxButtons.OK);
            }
        }

        public void Start_No(object sender, EventArgs e)
        {
            string message = "You will no longer be charged, $0.00 is your total";
            MessageBox.Show(message);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
