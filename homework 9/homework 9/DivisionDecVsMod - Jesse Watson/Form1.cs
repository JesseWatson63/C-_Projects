using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//jesse watson
//ID: 256777
//date: 10-31-2013
//The Goal of this program is to take 2 numbers and divide them together and give the user
//all the calculations
namespace DivisionDecVsMod___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {//here is all my decimale numbers
            decimal dividenNumber = 0;
            decimal divisorNumber = 0;
            decimal quotient = 0;
            decimal remainder = 0;
            decimal decima = 0;

            //My if else for validation
            if (decimal.TryParse(dividenTextBox.Text, out dividenNumber))
            {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Dividen");
                return;
            }

            if (decimal.TryParse(divisorTextBox.Text, out divisorNumber))
             {
            }
            else
            {
                MessageBox.Show("Please Enter A Valid Divisor");
                return;
            }
            //My math problems to give me all my answers
            quotient = dividenNumber / divisorNumber;
            remainder = dividenNumber % divisorNumber;
            decima = dividenNumber / divisorNumber;
            //to strings so them may be displayed
            quotientLabelBox.Text = quotient.ToString("n0");
            remainderLabelBox.Text = remainder.ToString("n0");
            decimalAnswerLabelBox.Text = decima.ToString("n3");

        }

        private void button1_Click(object sender, EventArgs e)
        {//Clear Button
            dividenTextBox.Text = "";
            divisorTextBox.Text = "";
            quotientLabelBox.Text = "";
            remainderLabelBox.Text = "";
            decimalAnswerLabelBox.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {//Close button
            this.Close();
        }
    }
}
