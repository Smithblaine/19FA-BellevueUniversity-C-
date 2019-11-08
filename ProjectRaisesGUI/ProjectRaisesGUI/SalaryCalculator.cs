using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRaisesGUI
{
    public partial class SalaryCalculator : Form
    {
        public SalaryCalculator()
        {
            InitializeComponent();
            calculate.Click += new EventHandler(Button_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int results;
            Int32.TryParse(userInput.Text, out results);
            //output.Text = "hello";
        }

        private void Button_Click(object sender, EventArgs e)
        {
            double results;
            double.TryParse(userInput.Text, out results);

            double total = results + (results * .04);
            
            output.Text = String.Format("{0:C}", total);
        }

    }
}
