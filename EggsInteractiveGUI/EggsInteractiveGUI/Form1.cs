//Blaine Smith
//11-08-2019
//Bellevue University
//Assignment 2.3
//This program allows a user to enter in the nuber of eggs for each chicken and will 
//calculate the total dozen of eggs and what is left over.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calc.Click += new EventHandler(Button_Click);
        }


        private void Button_Click(object sender, EventArgs e)
        {
            int totalEggs = 0;
            int eggRemainder = 0;
            int dozens = 0;

            //parsing user input
            int chic_1;
            int.TryParse(chic1.Text, out chic_1);
            int chic_2;
            int.TryParse(chic2.Text, out chic_2);
            int chic_3;
            int.TryParse(chic3.Text, out chic_3);
            int chic_4;
            int.TryParse(chic4.Text, out chic_4);
            int chic_5;
            int.TryParse(chic5.Text, out chic_5);

            //calculating totals and remainders
            totalEggs = chic_1 + chic_2 + chic_3 + chic_4 + chic_5;
            dozens = totalEggs / 12;
            eggRemainder = totalEggs % 12;

            output.Text = String.Format("A total for {0} eggs is {1} dozen and {2} eggs.", totalEggs, dozens, eggRemainder);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
