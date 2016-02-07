using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// jesse watson 
//256777
//Date:10-25-2013
//make a multiplier and a accumulator of ansers
namespace ExtraMultiAndAccum___jesse_watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //for the accumulator
        decimal accumAnswer1 = 0;
         
   



        private void button1_Click(object sender, EventArgs e)
        {
            //for my numbers
            decimal num1 = 0;
            decimal num2 = 0;
            decimal answer1 = 0;
            
            //This is the first TyrParse I have done. Seems easier if i did it correctly
            decimal.TryParse(number1.Text, out num1);
            decimal.TryParse(number2.Text, out num2);

            answer1 = num1 * num2;

            answer.Text = answer1.ToString("n3");

            accumAnswer1 = answer1 + accumAnswer1;

            accumAnswer.Text = accumAnswer1.ToString("n3");
        }
        //My clear button
        private void button2_Click(object sender, EventArgs e)
        {
            answer.Text = "";
            accumAnswer.Text = "";
            number1.Text = "";
            number2.Text = "";
            //haha got this, took me a min to figure out why my accumulator wasnt reseting.  Found this as a solution.
            accumAnswer1 = 0;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {//close Button
            this.Close();
        }
    }
}
