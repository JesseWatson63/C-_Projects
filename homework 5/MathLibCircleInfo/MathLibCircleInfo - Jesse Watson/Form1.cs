using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jesse Watson
//256777
//10-10-2013
//Purpose is to give the user some circle measurements  
namespace MathLibCircleInfo___Jesse_Watson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//The fixer for the crash
            try
            {//start of diameter of a circle
                decimal circleDiameter1 = 0;
                decimal circleDiameter2 = 0;

                circleDiameter1 = decimal.Parse(circleDiameter.Text);
                circleDiameter2 = circleDiameter1 * 2;

                diameter.Text = circleDiameter2.ToString("n");
                //end of diameter of a circle

                //start of circumference

                double circumference1 = 0;

                circumference1 = Math.PI * (double)circleDiameter2;

                circumference.Text = circumference1.ToString("n");

                //end of circumference

                //Start of area
                double area1 = 0;

                area1 = Math.PI * Math.Pow((double)circleDiameter2, 2);

                area.Text = area1.ToString("n");
            }
//catch for the try
            catch
            {
                MessageBox.Show("please enter a valid number");
            }
        }//clear button
        private void clear_Click(object sender, EventArgs e)
        {
            diameter.Text = "";
            circumference.Text = "";
            area.Text = "";
            circleDiameter.Text = "";
        }
        //close button
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
